using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateChainExample : MonoBehaviour
{
    delegate void CalculateChain(int a, int b);

    void Start()
    {
        CalculateChain cc = Add;
        cc += Subtract;
        cc += Subtract;
        cc += Add;
        
        cc(3, 2);
    }

    void Add(int a, int b)
    {
        Debug.Log($"Add: {a + b}");
    }
    
    void Subtract(int a, int b)
    {
        Debug.Log($"Subtract: {a - b}");
    }
}
