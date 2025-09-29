using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndexerClass
{
    const int LEN = 10;
    int[] data = new int[LEN];
    public int this[int index]
    {
        get
        {
            if (index >= 0 && index < LEN)
            {
                return data[index];
            }
            else
            {
                Debug.LogWarning("범위를 벗어났어요");
                return -1;
            }
        }
        set
        {
            if (index >= 0 && index < LEN)
            {
                data[index] = value;
            }
            else
            {
                Debug.LogWarning("범위를 벗어났어요");
            }
        }
    }
}

public class IndexerSample : MonoBehaviour
{
    void Start()
    {
        IndexerClass ic = new IndexerClass();
        // ic[1] = 1234;
        ic[11] = 1234;
        Debug.Log(ic[11]);

        int i = ic[11];
        Debug.Log(i);
    }
}
