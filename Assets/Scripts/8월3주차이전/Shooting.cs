using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bulletSpeed;

    private Inventory inven;

    void Awake()
    {
        inven = GetComponent<Inventory>();
    }

    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            inven.myStuff.bullets = 10;
        }

        if (Input.GetButtonDown("Fire1") && inven.myStuff.bullets > 0)
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(firePosition.forward * bulletSpeed);
            inven.myStuff.bullets--;
        }
    }
}
