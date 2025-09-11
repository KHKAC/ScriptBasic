using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSample : MonoBehaviour
{
    void Start()
    {
        // int i = 0;
        // for (i = 0; i < 10; i++)
        // {
        //     if (i < 7)
        //     {
        //         continue;
        //     }
        //     Debug.Log(i);
        //     // if (i > 8)
        //     // {
        //     //     break;
        //     // }
        // }
        // Debug.Log($"i : {i}");

        for (int i = 0; i < 10; i++) 
        { 
            if (i == 3) goto label; // i가 3이 되면, for 문을 벗어나서, label로 이동합니다. 
            Debug.Log(i); // 출력 : 0 1 2  
        } 

        label: 
        Debug.Log($"마지막"); // 출력: 마지막  
    }
}
