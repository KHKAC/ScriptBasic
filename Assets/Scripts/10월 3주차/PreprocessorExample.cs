#define Symbol1
#define Symbol2
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreprocessorExample : MonoBehaviour
{
    void Start()
    {
        int i = 0;
        if (i > 0)
        {

        }
        else if (i < 0)
        {

        }
        else
        {

        }
#if UNITY_EDITOR
#elif UNITY_STANDALONE_WIN
    #if (Symbol1 && !Symbol2)
        Debug.Log("Define1");
    #elif (!Symbol1 && Symbol2)
        Debug.Log("Define2");
    #elif (Symbol1 && Symbol2)
        Debug.Log("Both");
    #else
        Debug.Log("DefineOther");
    #endif
#elif UNITY_ANDROID || UNITY_IOS
#elif UNITY_WEBGL
#endif

    }

}
