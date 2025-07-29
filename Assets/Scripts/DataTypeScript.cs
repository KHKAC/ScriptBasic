using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTypeScript : MonoBehaviour
{
    public GameObject[] players;
    void Start()
    {
        //값 유형 변수 = value
        Vector3 pos = transform.position;
        pos = new Vector3(0, 2, 0);

        //레퍼런스(참조) 유형 변수 = reference
        Transform tran = transform;
        tran.position = new Vector3(0, 2, 0);

        //players = GameObject.FindGameObjectsWithTag("Player");
        for (int i = 0; i < players.Length; i++)
        {
            Debug.Log("Player Number " + i + " is named " + players[i].name);
        }
    }
}
