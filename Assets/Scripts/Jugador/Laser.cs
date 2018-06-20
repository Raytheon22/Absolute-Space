using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Laser : MonoBehaviour
{

    // Use this for initialization
    public RaycastHit hit;
    public Text texto;
    public Text Texto2;
    public LayerMask Mask;
    private bool Interactivo;
    private GameObject ObjetoGuardado;


    void Start()
    {

    }

    void Update()
    {
        //Cubo.transform.position = transform.position + transform.forward * 10;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 10, Mask.value))
        {
            ObjetoGuardado = hit.collider.gameObject;
            ObjetoGuardado.GetComponent<Interactivo>().Seleccionar();
            Interactivo = true;
            if (Input.GetKeyUp(KeyCode.E))
            {
                ObjetoGuardado.GetComponent<Interactivo>().Activar();
            }
        }
        else if (Interactivo)
        {
            ObjetoGuardado.GetComponent<Interactivo>().Deseleccionar();
            Interactivo = false;
        }
        Debug.DrawLine(transform.position, transform.position + transform.forward * 10, Color.red);

    }
}
