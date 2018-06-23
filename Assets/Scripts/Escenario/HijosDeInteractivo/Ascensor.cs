using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ascensor : Interactivo
{

    // Use this for initialization
    public GameObject Elevador;
    public GameObject Puerta;

    private Animator MotorAnimacion;
    public bool Arriba;
    void Start()
    {
        MotorAnimacion = Elevador.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public override void Activar()
    {
        if (!Arriba)
        {
            Puerta.gameObject.GetComponent<Interactivo>().Activar();
            Invoke("Subir", 10);
        }
        else
        {
            Puerta.gameObject.GetComponent<Interactivo>().Activar();
            Invoke("Bajar", 10);
        }

    }

    private void Bajar()
    {

        MotorAnimacion.SetBool("Subir", false);
        Arriba = !Arriba;
    }

    private void Subir()
    {
        MotorAnimacion.SetBool("Subir", true);
        Arriba = !Arriba;
    }
}
