using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeScript : MonoBehaviour
{
    public GameObject target;
    int sum;

    void Start()
    {
        sum = 0;
        //Invoke("SpawnObject", 2f);
        InvokeRepeating("SpawnObject", 2.0f, 1.0f);
    }

    void Update()
    {
        if (sum >= 10)
        {
            CancelInvoke("SpawnObject");
        }
    }

    void SpawnObject()
    {
        // Random.Range를 사용할 경우 int일 때와 float일 때의 차이
        // int i = Random.Range(-5, 5); // int는 Max값 포함하지않음.
        // float y = Random.Range(-5.0f, 5.0f); // float는 Max값 포함.

        float x = Random.Range(-3.0f, 3.0f);
        float z = Random.Range(-3.0f, 3.0f);
        Instantiate(target, new Vector3(x, 3, z), Quaternion.identity);
        sum++;
    }
}
