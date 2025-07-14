using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccess : MonoBehaviour
{
    public int alpha = 5;
    public int beta = 0;
    int gamma = 5;

    AnotherClass myOtherClass;

    void Start()
    {
        alpha = 29;
        myOtherClass = new AnotherClass();
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
    }

    void Example(int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
    }

    void Update()
    {
        Debug.Log("Alpha : " + alpha);
    }
}
