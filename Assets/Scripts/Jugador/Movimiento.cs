using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    [SerializeField] private CharacterController Controlador;
    [SerializeField] private float Aceleraccion;
    [SerializeField] private float FuerzaDeSalto;
    [SerializeField] private float Gravedad;
    [SerializeField] private GameObject Camara;


    public float VelocidadDeCaida;

    void Start()
    {
        Controlador = gameObject.GetComponent<CharacterController>();

    }


    void Update()
    {
        //Movimiento
        Vector3 mov = Vector3.zero;
        mov += transform.forward * Input.GetAxis("Vertical") * Aceleraccion;
        mov += transform.right * Input.GetAxis("Horizontal") * Aceleraccion;
        mov += transform.up * Input.GetAxis("Jump") * Gravedad * FuerzaDeSalto;
        if (!Controlador.isGrounded)
        {
            VelocidadDeCaida += 3;
            mov += Vector3.down * VelocidadDeCaida * Gravedad * Time.deltaTime;
        }
        else
        {
            VelocidadDeCaida = 0;
        }

        Controlador.Move(mov * Time.deltaTime);
    }
}
