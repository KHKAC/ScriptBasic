using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AxisExample : MonoBehaviour
{
    public float hRange;
    public float vRange;
    public Text textOutputH;
    public Text textOutputV;

    void Start()
    {
        
    }

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        float xPos = h * hRange;
        float yPos = v * vRange;

        transform.position = new Vector3(xPos, yPos, 0);
        textOutputH.text = "Value : " + h.ToString("F2");
        textOutputV.text = "Value : " + v.ToString("F2");
    }
}
