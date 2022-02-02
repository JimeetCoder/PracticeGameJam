using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour
{

    public Transform ShootingPoint;
    public GameObject BulletPrefab;

    public float BulletSpeed = 20f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }

    void Fire(){

        GameObject Bullet = Instantiate(BulletPrefab, ShootingPoint.position, ShootingPoint.rotation);

        Rigidbody2D RigidBodyBullet = Bullet.GetComponent<Rigidbody2D>();
        
        RigidBodyBullet.AddForce(ShootingPoint.up * BulletSpeed, ForceMode2D.Impulse);

    }
    
}
