using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EqualSample : MonoBehaviour
{
    void Start()
    {
        char c1 = 'a';
        char c2 = 'A';
        Debug.Log(c1 == c2); // False

        int a = 1 + 1 + 2 + 3;
        int b = 6;
        Debug.Log(a != b); // True
        Debug.Log(a.Equals(b)); // False
        Debug.Log(!a.Equals(b)); // True

        try
        {
            int[] i = new int[2];
            i[0] = 1;
            i[2] = 1;
        }
        catch(Exception ex)
        {
            Debug.LogException(ex);
        }
    }
}
