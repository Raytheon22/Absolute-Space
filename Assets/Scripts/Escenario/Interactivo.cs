using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactivo : MonoBehaviour
{
    private MeshRenderer Grafico;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    public virtual void Activar()
    {

    }
    public virtual void Seleccionar()
    {
        Grafico = GetComponent<MeshRenderer>();
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
    public virtual void Deseleccionar()
    {
        GetComponent<MeshRenderer>().material.color = Color.green;
    }


}

