using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private int healthValue = 100;

    public int HealthValue => this.healthValue; 

    public void TakeHit(int damage)
    {
        this.healthValue -= damage;
        if (this.healthValue <= 0)
        {
            Destroy(gameObject);
        }
    }
}
