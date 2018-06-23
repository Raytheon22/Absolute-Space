using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vibracion : MonoBehaviour
{

    // Use this for initialization
    public bool Despego;
    public float fuerza;
    public float duracion;
    public float Reduccion;

    Vector3 posicionInicial;
    float DuracionInicial;
    public GameObject Camara;

    void Start()
    {
        posicionInicial = Camara.transform.localPosition;
        DuracionInicial = duracion;
    }

    void Update()
    {
        if (gameObject.GetComponent<Despegue>().Despego)
        {
            if (duracion > 0)
            {
                Camara.transform.localPosition = posicionInicial + Random.insideUnitSphere * fuerza;
                duracion -= Time.deltaTime * Reduccion;
            }
            else
            {
                Camara.transform.localPosition = posicionInicial;
            }
        }
    }
}
