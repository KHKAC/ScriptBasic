using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultOperator : MonoBehaviour
{
    void Start()
    {
        // Debug.Log(default(int));
        // Debug.Log(default(float));
        // Debug.Log(default(char));
        // Debug.Log(default(string));
        // Debug.Log(default(bool));
        // Debug.Log(default(long));
        // Debug.Log(default(double));
        // Debug.Log(default(decimal));
        // Debug.Log(default(ulong));

        Debug.Log(sizeof(sbyte));
        Debug.Log(sizeof(byte));
        Debug.Log(sizeof(short));
        Debug.Log(sizeof(ushort));
        Debug.Log(sizeof(int));
        Debug.Log(sizeof(uint));
        Debug.Log(sizeof(long));
        Debug.Log(sizeof(ulong));
        Debug.Log(sizeof(char));
        Debug.Log(sizeof(float));
        Debug.Log(sizeof(double));
        Debug.Log(sizeof(decimal));
        Debug.Log(sizeof(bool));
        // Debug.Log(sizeof(string)); // string은 참조형식이다. string의 사이즈를 구하려면 .Length를 사용하면 된다.
    }
}
