using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IBase1
{
    // 인터페이스에선 구현 불가 {} 불가능
    public void Method11();
}

interface IBase2
{
    public void Method21();
}

public class Class11 : IBase1, IBase2
{
    public void Method11()
    {
        Debug.Log("Interface Method11");
    }
    public void Method21()
    {
        Debug.Log("Interface Method21");
    }
}
public class InterfaceSample : MonoBehaviour
{
    void Start()
    {
        // IBase1 ib1 = new IBase1();
        Class11 c11 = new Class11();
        c11.Method11();
        c11.Method21();
    }

}
