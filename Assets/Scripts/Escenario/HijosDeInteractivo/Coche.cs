using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coche : Interactivo
{

    public GameObject Jugado;
    public GameObject Auto;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public override void Activar()
    {
        Jugado.GetComponentInChildren<Movimiento>().enabled = false;
        Jugado.transform.position = transform.localPosition;
        Auto.GetComponent<CocheMovimiento>().Arrancar();
    }
}
