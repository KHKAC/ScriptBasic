using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class ThreadExample : MonoBehaviour
{
    void Start()
    {
        Thread thread = new Thread(Run);
        thread.Start(); 

        for (int i = 0; i < 3; i++) 
        {
            Debug.LogFormat($"메인 스레드 : {i}");
            Thread.Sleep(100); 
        }

        thread.Join();
        Debug.Log("메인 스레드 종료");
    }

    static void Run()
    {
        for (int i = 0; i < 5; i++) 
        {
            Debug.LogFormat($"서브 스레드 : {i}");
            Thread.Sleep(100); 
        }
        Debug.Log("서브 스레드 종료");
    }
}
