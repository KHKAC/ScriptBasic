using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryCatchSample : MonoBehaviour
{
    GameObject go;

    void Start()
    {
        // go = new GameObject();
        // Debug.Log(go.name);
        try
        {
            Debug.Log(go.name);
        }

        catch (Exception ex) // NullReferenceException 같은 것도 쓸 수 있음.
        {
            Debug.Log(ex);
            throw new Exception("임의로 만든 예외입니다!");
        }

        // try catch가 존재하지 않았을 때 Exception이 발생하면 그 아래는 실행되지 않는다.
        //Debug.Log("여기도 실행됩니다!")

        finally
        {
            Debug.Log("여기는 실행됩니다.");
        }
        // catch하지 않았을 시
        // Debug.Log("여기는 실행되지 않습니다!");
        Debug.Log("이제 여기도 실행됩니다!");

        // throw sample
        throw new Exception("임의로 만든 예외입니다!");
        // throw 이후 실행되는지 확인
        Debug.Log("이제 여기도 실행됩니다!");
    }
}
