using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour
{
    int numEnemies = 3;
    void Start()
    {
        for (int i = 0; i < numEnemies; i++)
        {
            //Debug.Log("Enemy : " + i);
        }

        var iArray = new int[10];
        for (int i = 0; i < iArray.Length; i++)
        {
            iArray[i] = i;
        }
        for (int i = 9; i >= 0; i -= 2)
        {
            Debug.Log(iArray[i]);
        }
    }
}
