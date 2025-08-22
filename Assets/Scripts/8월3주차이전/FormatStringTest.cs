using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormatStringTest : MonoBehaviour
{
    void Start()
    {
        string[] names = { "Iron Man", "Super Man" }; 
        int[] ages = { 55, 100 }; 

        Debug.LogFormat("{0,-20} {1,5}", "Name", "Age"); 
        Debug.LogFormat("{0,-20} {1,5:N1}", names[0], ages[0]); 
        Debug.LogFormat("{0,-20} {1,5:N1}", names[1], ages[1]);
    }
}
