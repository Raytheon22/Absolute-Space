using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VitalisStats : MonoBehaviour
{

    // Use this for initialization
    [SerializeField] private int Vida;
    [SerializeField] private int Combustible;
    [SerializeField] private float FuerzaMaxima;

    void Update()
    {
        if (Vida <= 0)
        {
            Explotar();
        }
        if (Combustible <= 0)
        {
            Debug.Log("Sin Nafta");
        }
    }
    public void RecibirDaño(int cantidad)
    {
        Vida -= cantidad;
    }
    public void ConsumirConbustible()
    {
        Combustible -= 2;
    }
    void Explotar()
    {
        Debug.Log("Exploto");
    }
    void OnCollisionEnter(Collision Objecto)
    {
        RecibirDaño(5);
        if (Objecto.relativeVelocity.x > FuerzaMaxima)
        {
            RecibirDaño(100);
        }
        if (Objecto.relativeVelocity.y > FuerzaMaxima)
        {
            RecibirDaño(100);
        }
        if (Objecto.relativeVelocity.z > FuerzaMaxima)
        {
            RecibirDaño(100);
        }
    }
}
