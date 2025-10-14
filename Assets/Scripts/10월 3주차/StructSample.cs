using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StructSample : MonoBehaviour
{
    // int, bool, float 등 값 형식인 것들은 스트럭트라고 생각하면 됨.
    public struct Struct
    {
        public int a, b;
        public Struct(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void DebugLog()
        {
            Debug.LogFormat($"a = {a}, b = {b}");
        }
    }

    void Start()
    {
        Struct str1;
        str1.a = 10;
        str1.b = 20;
        str1.DebugLog();

        //Struct str2 = new Struct(1, 2);
        Struct str2 = new Struct();
        str2.DebugLog();

        for(int i = 0; i < 100; i++)
        {
            
        }
    }
}
