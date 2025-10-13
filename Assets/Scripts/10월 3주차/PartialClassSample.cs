using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class PartialClass
    {
        public void DebugLog1()
        {
            Debug.Log("DebugLog1");
        }
    }

    public partial class PartialClass
    {
        public void DebugLog2()
        {
            Debug.Log("DebugLog2");
        }
    }

public class PartialClassSample : MonoBehaviour
{
    PartialClass partialClass;
    void Start()
    {
        partialClass = new PartialClass();
        partialClass.DebugLog1();
        partialClass.DebugLog2();
    }
}
