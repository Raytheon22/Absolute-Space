using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxDespegue : MonoBehaviour
{

    // Use this for initialization
    public float VelocidadDeRotacion = 1.0f;
    public float CantidadDeOscuridad;
    public bool Despego;
    void Start()
    {
        CantidadDeOscuridad = RenderSettings.skybox.GetFloat("_Exposure");
    }

    // Update is called once per frame
    void Update()
    {
        if (Despego)
        {
            CantidadDeOscuridad -= 0.1f * Time.deltaTime;
            RenderSettings.skybox.SetFloat("_Exposure", CantidadDeOscuridad);
        }
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * VelocidadDeRotacion);
    }

}
