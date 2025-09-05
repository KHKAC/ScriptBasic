using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsIsSample : MonoBehaviour
{
    void Start()
    {
        int i = 1;
        object iBoxed = i;

        // Debug.Log((iBoxed is int).ToString());
        // Debug.Log((iBoxed is float).ToString());

        object o = 1.1f;
        int? i2 = o as int?;
        if (i2 == null)
        {
            Debug.Log("Null");
        }
        else
        {
            Debug.Log(i2.ToString());
        }

        Debug.Log(typeof(int));
        i = 1;
        Debug.Log(i.GetType());
    }

}
