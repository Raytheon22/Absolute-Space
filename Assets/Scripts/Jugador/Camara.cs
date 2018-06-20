using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Camara : MonoBehaviour
{
    public GameObject Ojos;
    public Gyroscope Sensor;
    public Quaternion CelularOrientacionCorregida;
    public Quaternion CorrecionHorizontal;
    public Quaternion CorrecionVertical;
    public Quaternion UbicacionEnJuego;
    public int AnguloVerticalOffset = -90;
    public int AnguloHorizontalOffset = 0;
    public bool ExisteGyroscopio;

    void Start()
    {
        if (SystemInfo.supportsGyroscope)//chequea si hay giroscopio en el hardware
        {
            ExisteGyroscopio = true;
            Sensor = Input.gyro;
            Sensor.enabled = true;
            calibrar();
        }
        else
        {
            //mostrar cartelito que no hay giroscopio
        }
    }
    void Update()
    {
        transform.position = Ojos.transform.position;//Sigue a la capsula
        if (ExisteGyroscopio)//Chequea si hay gyroscopio
        {
            calibrar();
        }
    }
    void calibrar()
    {
        CelularOrientacionCorregida = new Quaternion(Sensor.attitude.x, Sensor.attitude.y, -Sensor.attitude.z, -Sensor.attitude.z);//voltea el eje de unity 
        CorrecionVertical = Quaternion.AngleAxis(AnguloVerticalOffset, Vector3.left);//Corrige el eje vertical
        CorrecionHorizontal = Quaternion.AngleAxis(AnguloHorizontalOffset, Vector3.up);//corrige el eje horizontal
        UbicacionEnJuego = CorrecionHorizontal * CorrecionVertical * CelularOrientacionCorregida;//Corrige los valores para que funcionen en la camara
        transform.rotation = Quaternion.Slerp(transform.rotation, UbicacionEnJuego, 0.2f);//Mueve la camara donde este el giroescopio
    }
}

