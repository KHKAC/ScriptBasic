using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericExample : MonoBehaviour
{
    public class GenericsClass<T>
    {
        T value;
        public GenericsClass(T value)
        {
            this.value = value;
        }

        public void Method1()
        {
            Debug.Log(value);
        }
    }

    void Start()
    {
        /*
        GenericsClass<int> genericsClass1 = new GenericsClass<int>(5);
        genericsClass1.Method1();

        GenericsClass<float> genericsClass2 = new GenericsClass<float>(5.1f);
        genericsClass2.Method1();
        */
        int iX = 1, iY = 2;
        Swap(ref iX, ref iY);
        Debug.Log($"x = {iX}, y = {iY}");
        // Tuple 사용 swap
        (iX, iY) = (iY, iX);
        Debug.Log($"x = {iX}, y = {iY}");
        
        string sX = "ab", sY = "cd";
        Swap(ref sX, ref sY);
        Debug.Log($"x = {sX}, y = {sY}");
    }
    void Swap<T>(ref T x, ref T y)
    {
        var temp = y;
        y = x;
        x = temp;
    }
}
