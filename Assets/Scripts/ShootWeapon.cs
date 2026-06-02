using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootWeapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float fireRate = 1f;
    float nextFire = 0f;
    public bool canShoot = true;


    private void Start()
    {
        nextFire = Time.time;

    }





    public void Fire(InputAction.CallbackContext context)
    {

       
        if (Time.time >= nextFire)
        {
            nextFire = Time.time + 1f / fireRate;
            //Debug.Log("I can fire");
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
        // Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
