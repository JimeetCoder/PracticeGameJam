using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
   
    public GameObject BulletExplosion;

    void OnCollisionEnter2D(Collision2D BulletCollision)
    {
        GameObject ExplosionEffect = Instantiate(BulletExplosion, transform.position, Quaternion.identity);
        Destroy(ExplosionEffect, .1f);
        Destroy(gameObject);
    }

}
