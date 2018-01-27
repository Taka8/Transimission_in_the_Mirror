using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : CharacterHealth
{

    void Start()
    {
        currentHealth = maxHealth;
    }

    public override void ApplyDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0) Death();
    }

    public override void Death()
    {
        Destroy(gameObject);
    }

}
