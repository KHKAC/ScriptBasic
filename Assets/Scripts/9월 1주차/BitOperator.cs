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

        uint a = 0b_1100_1010;
        uint b = 0b_1101_1101;
        uint c = a & b;
        Debug.Log(Convert.ToString(c, toBase: 2));
    }
}
