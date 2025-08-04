using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControls : MonoBehaviour
{
    public float speed;
    public float turnSpeed;

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float fowardMovement = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        float turnMovement = Input.GetAxis("Horizontal") * Time.deltaTime * turnSpeed;

        transform.Translate(Vector3.forward * fowardMovement);
        transform.Rotate(Vector3.up * turnMovement);
    }
}
