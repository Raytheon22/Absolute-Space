using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CocheMovimiento : MonoBehaviour
{

    // Use this for initialization
    public float tiempo;
    public GameObject Jugador;
    public GameObject Asiento;
    bool Arrancando;

    void Start()
    {
        tiempo = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Arrancando)
        {
            tiempo -= 0.1f * Time.deltaTime;
        }
        if (tiempo <= 0)
        {
            Arrancando = false;
            Moverse();
        }

    }
    public void Arrancar()
    {
        Arrancando = true;
    }
    void Moverse()
    {
        Jugador.transform.position = this.transform.localPosition;
        transform.Translate(-1 * Time.deltaTime, 0, 0);
    }

}
