using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fps : MonoBehaviour
{

    // Use this for initialization
    float deltatime = 0.0f;
    public Text texto;
    public Text Texto2;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        deltatime += (Time.deltaTime - deltatime) * 0.1f;
    }

    void OnGUI()
    {
        float msc = deltatime * 1000f;
        float fps = 1.0f / deltatime;
        texto.text = "FPS: " + fps +" " + Input.inputString;
        Texto2.text = "FPS: " + fps +" " +  Input.inputString;

    }
}
