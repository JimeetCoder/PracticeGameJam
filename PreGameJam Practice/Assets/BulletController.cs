using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
   
    public GameObject BulletExplosion;
    public int Damage = 20;
    void OnTriggerEnter2D(Collider2D CollisionInfo){


        EnemyController Enemy = CollisionInfo.GetComponent<EnemyController>();
        if (Enemy != null)
        {
            Enemy.TakeDamage(Damage);
        }

        GameObject ExplosionEffect = Instantiate(BulletExplosion, transform.position, Quaternion.identity);

        Destroy(ExplosionEffect, 1f);
        
        Destroy(gameObject);

    }
    // void OnCollisionEnter2D(Collision2D BulletCollision)
    // {   
    //     GameObject ExplosionEffect = Instantiate(BulletExplosion, transform.position, Quaternion.identity);
    //     Destroy(ExplosionEffect, 1f);
    //     Destroy(gameObject);
    // }
    
}
