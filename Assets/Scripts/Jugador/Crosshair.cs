using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crosshair : MonoBehaviour
{

    // Use this for initialization


    [SerializeField] private Image imagen1;
    [SerializeField] private Image imagen2;

    private float Ancho;
    private float Alto;

    void Start()
    {
        Ancho = GetComponent<RectTransform>().rect.width / 2 / 2;
        Alto = GetComponent<RectTransform>().rect.height / 2;
        imagen1.rectTransform.position = new Vector3(Ancho, Alto);
        Ancho = Ancho *3;
        imagen2.rectTransform.position = new Vector3(Ancho, Alto);
    }


}
