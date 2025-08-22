using System.Collections;
using System.Collections.Generic;
using JetBrains.Rider.Unity.Editor;
using UnityEngine;

public class SingleCharacter : MonoBehaviour
{
    public class Stuff
    {
        public int bullets;
        public int grenades;
        public int rockets;

        public Stuff(int bul, int gre, int roc)
        {
            bullets = bul;
            grenades = gre;
            rockets = roc;
        }
    }

    public Stuff myStuff = new Stuff(10, 7, 25);
    public float speed;
    public float turnSpeed;
    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bulletSpeed;

    void Update()
    {
        Movement();
        Shoot();
    }

    void Movement()
    {
        float fowardMovement = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        float turnMovement = Input.GetAxis("Horizontal") * Time.deltaTime * turnSpeed;

        transform.Translate(Vector3.forward * fowardMovement);
        transform.Rotate(Vector3.up * turnMovement);
    }

    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            myStuff.bullets = 10;
        }

        if (Input.GetButtonDown("Fire1") && myStuff.bullets > 0)
            {
                Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
                bulletInstance.AddForce(firePosition.forward * bulletSpeed);
                myStuff.bullets--;
            }
    }
}
