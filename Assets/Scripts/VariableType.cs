using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableType : MonoBehaviour
{
    //filed
    static public bool isStaticVaiable = true;
    public int publicValue = 1;
    public int publicValue2 = 4;
    public bool isPublic = false;
    int globalVariable = 1;

    void Start()
    {
        int localVariable = 1;
        int localVariable2;

        //Debug.Log(localVariable2); <- localVariable2를 초기화 안 해서 에러
        LocalVariable(1 /* 매개변수 */);
        Debug.Log(publicValue2);

    }

    void LocalVariable(int parameter)
    {
        float localVariable = parameter;
    }
}
