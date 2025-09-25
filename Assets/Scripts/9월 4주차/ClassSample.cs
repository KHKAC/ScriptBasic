using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class1
{
    public static int staticInt;
    public int intVariable;
    string stringVariable;

    public Class1() { } // 기본 생성자
    public Class1(int i) // 일반 생성자
    {
        intVariable = i;
    }
    public void DebugLog(string message)
    {
        stringVariable = message;
        Debug.Log(message);
    }

    public void Start()
    {
        Debug.Log($"Start class1, iv = {intVariable}");
    }
    public static void StaticMethod()
    {
        staticInt++;
        // intVariable++; // 이건 static이 아니라 에러
    }
}

public class ClassSample : MonoBehaviour
{

    //Class1 class1 = new Class1();
    Class1 class1 = new Class1(100);
    int property = 0;
    public int Property
    {
        get
        {
            Debug.Log("Get Property");
            return property;
        }
        set
        {
            if (value > 100) value = 101;
            property = value;
        }
    }

    public int Pty2 { get; set; }

    void Awake()
    {
        //property = 1;
        Property = 666;
    }

    public void Start()
    {
        Class1.staticInt = 1;
        class1.DebugLog("Example");
        class1.Start();
        // property = 100;
        Debug.Log(property);
    }

    // public void SetProperty(int val)
    // {
    //     if (val > 100) val = 101;
    //     property = val;
    // }
}
