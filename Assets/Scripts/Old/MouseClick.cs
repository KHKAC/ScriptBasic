using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    Rigidbody rb; // 물리법칙에 의해서 움직이게 만들고 싶다

    void Awake()
    {
        rb = GetComponent<Rigidbody>();   
    }

    void OnMouseDown()
    {
        rb.AddForce(transform.up * 500f);
        rb.useGravity = true;
    }
}
