using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LambdaSample : MonoBehaviour
{
    delegate int Method(int a, int b);

    void Start()
    {
        Method Add = (a, b) => a + b;
        Debug.Log(Add(1, 2));

        Method Minus = (a, b) =>
        {
            return a - b;
        };
        Debug.Log(Minus(4, 3));
    }
}
