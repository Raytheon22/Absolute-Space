using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luces : Interactivo
{

    // Use this for initialization
    public GameObject Luz;
    private bool Activado;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public override void Activar()
    {
        Activado = !Activado;
        Luz.gameObject.GetComponent<Light>().enabled = Activado;
    }
}
