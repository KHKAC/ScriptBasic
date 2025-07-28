using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySample : MonoBehaviour
{
    public GameObject other;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            //Destroy(gameObject);
            //Destroy(other);
            Destroy(other.GetComponent<MeshRenderer>());
        }
    }
}
