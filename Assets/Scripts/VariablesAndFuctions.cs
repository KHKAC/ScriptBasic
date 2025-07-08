using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFuctions : MonoBehaviour
{
    void Start()
    {
        myInt = MultiplyByThree(myInt);
        Debug.Log(myInt);
    }

    int MultiplyByThree(int number)
    {
        int result;
        result = number * 3;
        return result;
    }
    
    //클래스 내에서 변수 위치는 상관없다.
    int myInt = 5;
}
