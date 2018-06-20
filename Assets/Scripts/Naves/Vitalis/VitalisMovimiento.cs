using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VitalisMovimiento : MonoBehaviour
{

    [SerializeField]// Use this for initialization
    private bool PilotoAutomaticoDesactivado;
    private Rigidbody Fisica;
    private VitalisStats Caracteristicas;
    void Start()
    {
        Fisica = gameObject.GetComponent<Rigidbody>();
        Caracteristicas = GetComponent<VitalisStats>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PilotoAutomaticoDesactivado)
        {
            if (Input.GetKey(KeyCode.J))
            {
                Fisica.AddForce(transform.forward * 5);
                Caracteristicas.ConsumirConbustible();
            }
            if (Input.GetKey(KeyCode.H))
            {
                Fisica.AddForce(transform.forward * -5);
                Caracteristicas.ConsumirConbustible();
            }
            Quaternion Aceleracion = Quaternion.Euler(0, Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));
            Fisica.MoveRotation(Fisica.rotation * Aceleracion);

        }
    }
}
