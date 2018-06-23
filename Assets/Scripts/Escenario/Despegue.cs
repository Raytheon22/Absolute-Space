using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despegue : MonoBehaviour
{
    public bool Despego;
    public bool InicioConteo;
    public float Velocidad;
    public float Tiempo;
    // Use this for initialization

    void Start()
    {
        Velocidad = 0.1f;
        Tiempo = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        if (InicioConteo)
        {
            Tiempo -= 1f * Time.deltaTime;
        }
        if (Tiempo <= 0)
        {
            InicioConteo = false;
            Despego = true;
            this.GetComponent<SkyBoxDespegue>().Despego = true;
        }
        if (Despego)
        {
            if (Velocidad < 500f)
            {
                Velocidad += 0.5f;
            }
            transform.Translate(0, Velocidad * Time.deltaTime, 0);
        }

    }
}
