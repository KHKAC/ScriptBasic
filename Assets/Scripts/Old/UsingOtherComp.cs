using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingOtherComp : MonoBehaviour
{
    public GameObject otherGameObject;

    AnotherScript anotherScript;
    YetAnotherScript yetAnotherScript;
    BoxCollider boxcol;

    void Awake()
    {
        anotherScript = GetComponent<AnotherScript>();
        yetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>();
        boxcol = otherGameObject.GetComponent<BoxCollider>();
    }
    void Start()
    {
        boxcol.size = new Vector3(3, 3, 3);
        Debug.Log("Player score : " + anotherScript.playerScore);
        Debug.Log("Player died" + yetAnotherScript.numberOfPlayerDeaths + "times");
    }
}
