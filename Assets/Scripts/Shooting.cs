using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    float bulletForce=20f;
    public ParticleSystem muzzleFlash;

    private void Update()
    {
        muzzleFlash.gameObject.transform.position = firePoint.position;
        if (Input.GetButtonDown("Fire1"))
        {
            muzzleFlash.Play();
            Shoot();
           
        }
    }
    void Shoot()
    {
        GameObject bullet= Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();
        bulletRb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

    }
}
