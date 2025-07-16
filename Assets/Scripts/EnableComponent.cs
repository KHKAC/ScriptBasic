using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableComponent : MonoBehaviour
{
    Light myLight;

    void Start()
    {
        //연결하기 전에 쓰려고 하면 에러난다.
        myLight = GetComponent<Light>();
        myLight.enabled = true;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            myLight.enabled = !myLight.enabled;
        }
    }
}
