using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableExample : MonoBehaviour
{
    int globalNumber;
    void Start()
    {
        //지역 변수는 값이 필요함, 전역 변수는 기본값이 바로 들어감.
        int localNumber;
        localNumber = 1;
        Console.WriteLine(globalNumber);
        Console.WriteLine(localNumber);

        int number1; 
        number1 = 1; 
        int number2 = 2;
        float newNumber = 3.4f, number4 = 4f;
        bool isBool = true;
        bool isTrue = true;
        bool isOver = false;

        if (isOver)
        {

        }
        else
        {
            
        }

        Debug.Log(number1);
        Debug.Log(number1.ToString());
        // 정의되어있는 곳 단축키 F12
        Debug.Log(newNumber);
        Debug.Log("newNumber");
        Debug.Log(newNumber.ToString());
        Debug.Log(isBool);
        Debug.Log(isBool.ToString());
    }

}
