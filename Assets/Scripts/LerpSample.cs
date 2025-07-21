using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpSample : MonoBehaviour
{
    public Light light;
    void Start()
    {
        Vector3 from = new Vector3(1f, 2f, 3f);
        Vector3 to = new Vector3(5f, 6f, 7f);

        Vector3 result = Vector3.Lerp(from, to, 0.75f);
        Debug.Log(result);
    }

    void Update()
    {
        light.intensity = Mathf.Lerp(light.intensity, 8, 0.5f * Time.deltaTime * 0.1f);
    }
}
