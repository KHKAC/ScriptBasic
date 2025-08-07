using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastSample : MonoBehaviour
{
    void Start()
    {
        // int i1 = 1;
        // float f1 = i1;

        // float x = 1.234f;
        // int a = (int)x; // 실수형 값을 정수형에 넣을 수 없음.

        // byte[] bytes = { 0, 1, 2, 34 };
        // int i = BitConverter.ToInt32(bytes, 0); // 많이 안 쓰임.

        string s1 = "abcde";
        int i1 = 0;
        bool result = int.TryParse(s1, out i1);
        Debug.Log($"Try Parse : {result}, i1 = {i1}");

        try
        {
            int i2 = Convert.ToInt32(s1);
            Debug.Log($"Convert : i2 = {i2}");
        }
        catch (Exception ex)
        {
            Debug.LogWarning("Exception!!!");
        }
        

        string s2 = "123.45";
        float f2 = float.Parse(s2); // "abc" 같은 글자는 int.Parse/float.Parse를 사용하더라도 정수형으로 변환 불가(Format이 다르니까)
        Debug.Log(f2);
    }
}
