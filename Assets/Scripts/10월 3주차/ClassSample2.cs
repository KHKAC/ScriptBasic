using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseClass
{
    public string stringVariable;
    public int intVariable { get; set; }
}

// 추상 클래스 & 메서드
abstract public class AbsBaseClass
{
    abstract public void Method();
}

// Override
public class DerivedClass3 : AbsBaseClass
{
    override public void Method()
    {
        Debug.Log("Abstract Method");
    }
}


public class DerivedClass1 : BaseClass
{
    public void Method()
    {
        Debug.Log(stringVariable);
    }
}

public class DerivedClass2 : BaseClass
{
    public void Method()
    {
        Debug.Log(intVariable);
    }
}

public class ClassSample2 : MonoBehaviour
{
    // DerivedClass1 baseClass1 = new DerivedClass1();
    BaseClass baseClass1 = new DerivedClass1(); // 부모 클래스가 자식 클래스의 형태를 받는 것도 가능함.
    DerivedClass2 baseClass2 = new DerivedClass2();
    // AbsBaseClass bc1 = new AbsBaseClass();
    DerivedClass3 dc1 = new DerivedClass3();

    void Start()
    {
        baseClass1.stringVariable = "DerivedClass1";
        ((DerivedClass1)baseClass1).Method();
        baseClass2.intVariable = 3;
        baseClass2.Method();
        dc1.Method();
    }

}
