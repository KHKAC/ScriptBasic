using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateExample : MonoBehaviour
{
    // delegate int CalculateDelegate(int a, int b);
    delegate T CalculateDelegate<T>(T a, T b);

    void Start()
    {
        CalculateDelegate<int> Plus = new CalculateDelegate<int>(Add);
        CalculateDelegate<float> Minus = new CalculateDelegate<float>(Subtract);
        CalculateDelegate<int> Multi = Multiple;

        DebugLog(1, 2, Plus);
        DebugLog(4.1f, 3.2f, Minus);
        DebugLog(2, 5, Multi);
    }

    void DebugLog<T>(T a, T b, CalculateDelegate<T> cd)
    {
        var val = cd(a, b);
        Debug.Log(val);
    }

    int Add(int a, int b)
    {
        return a + b;
    }

    float Subtract(float a, float b)
    {
        return a - b;
    }
    
    int Multiple(int a, int b)
    {
        return a * b;
    }
}
