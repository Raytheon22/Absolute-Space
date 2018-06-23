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
        Jugado.GetComponent<Movimiento>().enabled = false;
        Jugado.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
        Jugado.GetComponent<UnityEngine.AI.NavMeshAgent>().SetDestination(this.transform.position);
        //Jugado.transform.position = transform.position;
        Auto.GetComponent<CocheMovimiento>().Arrancar();

    }
}
