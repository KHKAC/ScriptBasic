using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BitOperator : MonoBehaviour
{
    void Start()
    {
        /*
        uint a = 0b_0010_1101_0100_1111_0000_1111_0000_1100;
        uint b = ~a;
        Debug.Log(Convert.ToString(b, toBase: 16));
        */

        /*
        uint a = 0b_1100_1010;
        uint b = 0b_1101_1101;
        uint c = a & b;
        Debug.Log($"&(and): {Convert.ToString(c, toBase: 2)}");
        c = a | b;
        Debug.Log($"|(or): {Convert.ToString(c, toBase: 2)}");
        c = a ^ b;
        Debug.Log($"^(xor): {Convert.ToString(c, toBase: 2)}");
        */

        uint x1 = 0b_1100_1001_0000_0000_0000_0000_0001_0001; 
        Debug.Log($"원래 값: {Convert.ToString(x1, toBase: 2)}"); 

        uint y1 = x1 >> 2; 
        Debug.Log($"오른쪽 >>: {Convert.ToString(y1, toBase: 2)}"); 
        uint y2 = x1 << 2; ; 
        Debug.Log($"왼쪽 <<: {Convert.ToString(y2, toBase: 2),4}");
    }
}
