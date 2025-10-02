using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParameterSample : MonoBehaviour
{
    void Start()
    {
        /*
        NamedParameter("Kyoung", 33, 170.1f);
        NamedParameter(name: "HK", height: 170.1f, age: 33);
        NamedParameter(age: 10, name: "Kin", height: 10);
        // 생략되도 에러x, but 통일성을 위해 생략 왠만하면 하지말자.
        NamedParameter(name: "Yang", age: 90, 153.0f);
        */

        // OptionalParameter(1, 2.3f);
        // OptionalParameter(1, 2.3f, false);

        OP2(1, 2);
        OP2(1, 2, isInt: false);
        OP2(i: 3, j: 4, f: 2.1f);
        OP2(isInt: false, j: 3, i: 2);

    }

    void NamedParameter(string name, int age, float height)
    {
        Debug.Log($"Name: {name}, Age: {age}, Height: {height}");
    }

    void OptionalParameter(int i, float f, bool isInt = true)
    {
        if (isInt)
        {
            Debug.Log(i);
        }
        else
        {
            Debug.Log(f);
        }
    }

    void OP2(int i, int j, float f = 1.2f, bool isInt = true)
    {
        if (isInt)
        {
            Debug.Log(i + j);
        }
        else
        {
            Debug.Log(f);
        }
    }
}
