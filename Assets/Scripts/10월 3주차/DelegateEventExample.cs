using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class DelegateEventClass
{
    // Delegate를 만들고
    public delegate void DelegateMethod(string message);
    // Event를 사용해서 에러를 방지
    public event DelegateMethod EventMethod;
    public void MultipleOf5(int number)
    {
        if(number % 5 == 0 && number != 0)
        {
            EventMethod($"{number}는 5의 배수");
        }
    }
}

public class DelegateEventExample : MonoBehaviour
{
    void Start()
    {
        DelegateEventClass deClass = new DelegateEventClass();
        deClass.EventMethod += DebugLog;

        for(int i = 0; i < 30; i++)
        {
            deClass.MultipleOf5(i);
        }
    }

    void DebugLog(string message)
    {
        Debug.Log(message);
    }

}
