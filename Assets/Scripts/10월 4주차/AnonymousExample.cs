using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnonymousExample : MonoBehaviour
{
    delegate int MyDelegate(int a, int b);

    void Start()
    {
        /*
        var t = new { name = "Coderzero", age = 47 };
        Debug.Log($"{t.name}: {t.age}");
        */

        /*
        MyDelegate sum;
        sum = delegate (int a, int b)
        {
            return a + b;
        };
        Debug.Log($"Sum = {sum(1, 2)}");
        */

        MyDelegate cal = (a, b) => a + b;
        Debug.Log($"{1} + {2} = {cal(1, 2)}");
    }

    // int GetSum(int a, int b)
    // {
    //     return a + b;
    // }

}
