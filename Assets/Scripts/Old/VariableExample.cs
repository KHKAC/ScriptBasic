using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableExample : MonoBehaviour
{
    int globalNumber;
    void Start()
    {
        // 16진수 접두사 0x
        var hexLiteral = 0xaf;
        // 2진수 접두사 0b
        var binaryLiteral = 0b_1001_1010;

        // 최대값(.MaxValue), 최소값(.MinValue)
        int i = int.MaxValue;
        float f = float.MinValue;

        // bool 기본형
        bool b = default(bool); // b = false
        string s1 = null;
        string s2 = "";
        string s3 = string.Empty;

        if (s1 == s2)
        {
            Debug.Log("same");
        }
        else
        {
            Debug.Log("different");
        }
        //참조형식 에러를 확인하는 코드
        if (s1 != null)
        {
            
        }

        //nullable
        int? ii = null;
        ii = 20;
        if (ii == null)
        {
            ii = 30;
        }
        Nullable<float> ff = null;
        ff = 21.0f;

        //지역 변수는 값이 필요함, 전역 변수는 기본값이 바로 들어감
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
