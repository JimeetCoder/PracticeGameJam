using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public int Health = 100;

    public GameObject DeathEffect;
    

    public void TakeDamage (int Damage)
    {
        Health -= Damage;

        if (Health <= 0)
        {
            Death();
        }
    }
    void Death(){
        Instantiate(DeathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
