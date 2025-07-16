using UnityEngine;
using System.Collections;

public class AnotherClass
{
    public int apples;
    public int bananas;

    int stapler;
    int sellotape;

    public void FruitMachine(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Fruit total" + answer);
    }

    void OfficeSort(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Office Supplies total : " + answer);
    }
}