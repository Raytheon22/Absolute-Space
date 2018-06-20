using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFps : MonoBehaviour
{

    // Use this for initialization
    public float Velocidad;
    public float Aceleracion;
    public GameObject Camera;
    public float h;
    public float v;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        v = Velocidad * Input.GetAxis("Mouse X");
        h = Aceleracion * Input.GetAxis("Mouse Y");
        transform.Rotate(0, v, 0);
        Camera.transform.Rotate(-h, 0, 0);
    }
}
