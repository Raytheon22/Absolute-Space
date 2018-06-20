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
    [SerializeField] private GameObject Ojos;
    void Start()
    {
        Controlador = gameObject.GetComponent<CharacterController>();

    }


    void Update()
    {
        //Seguimiento
        Ojos.transform.position = transform.position;
        Camara.transform.position = Ojos.transform.position;
        transform.rotation = Camara.transform.rotation;
       
       //Movimiento
        Vector3 mov = Vector3.zero;
        mov += transform.up * Input.GetAxis("Jump") * Gravedad * FuerzaDeSalto;
        mov += transform.forward * Input.GetAxis("Vertical") * Aceleraccion;
        mov += transform.right * Input.GetAxis("Horizontal") * Aceleraccion;
        mov += Vector3.down * FuerzaDeSalto;
        Controlador.Move(mov * Time.deltaTime);
    }
}
