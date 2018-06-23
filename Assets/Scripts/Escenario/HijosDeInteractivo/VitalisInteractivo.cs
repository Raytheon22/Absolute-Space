using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VitalisInteractivo : Interactivo
{

    // Use this for initialization
    public GameObject Asiento;
    public GameObject Jugador;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public override void Activar()
    {
        gameObject.GetComponent<Despegue>().InicioConteo = true;
        Jugador.GetComponent<Movimiento>().enabled = false;
        Jugador.transform.position = Asiento.transform.position;
        Jugador.transform.rotation = Asiento.transform.rotation;
        Jugador.transform.parent = Asiento.transform;
    

    }
}
