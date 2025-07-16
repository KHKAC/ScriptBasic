using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    Renderer rd;
    Color myColor;
    void Start()
    {
        rd = GetComponent<Renderer>();
        myColor = GetComponent<Renderer>().material.color;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            myColor = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            myColor = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            myColor = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            myColor = Color.white;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            myColor = Color.yellow;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            myColor = Color.cyan;
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            myColor = Color.magenta;
        }

        rd.material.color = myColor;

    }
}
