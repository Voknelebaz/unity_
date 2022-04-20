using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour
{
    public int damage = 10;
    public string collisionTarget;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.CompareTag(this.collisionTarget))
        {
            return;
        }

        Health targetHealth = other.gameObject.GetComponent<Health>();
        targetHealth.TakeHit(this.damage);
    }
}
