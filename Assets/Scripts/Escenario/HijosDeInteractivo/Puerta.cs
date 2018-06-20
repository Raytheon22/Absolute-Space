using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : Interactivo
{


    public GameObject Estructura;

    public bool Abierta;
    public Animation MotorDeAnimacion;
    void Start()
    {
        MotorDeAnimacion = Estructura.GetComponent<Animation>();
    }
    public override void Activar()
    {
        if (!Abierta)
        {
            MotorDeAnimacion.Play("Abrir");
            Abierta = true;
        }
        else
        {
            MotorDeAnimacion.Play("Cerrar");
            Abierta = false;
        }
    }


}
