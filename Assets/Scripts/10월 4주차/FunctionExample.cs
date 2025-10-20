using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FunctionExample : MonoBehaviour
{
    void Start()
    {
        Func<int> func1 = () => 1;
        Debug.Log($"Func1: {func1()}");

        Func<int, int> func2 = (a) => a * 2;
        Debug.Log($"Func2: {func2(3)}");

        Action action1 = () => Debug.Log("Action");
        action1();

        Action<int, int> action2 = (a, b) => Debug.Log($"{a}, {b}");
        action2(1, 2);

        Func<int, int, int, int> f3 = (x, y, z) => x * y + z;
        int answer = f3(4, 6, 2);

        Action<int> ac3 = (x) =>
        {
            x = x * 2;
            Debug.Log(x);
        };
        ac3(37);
    }

}
