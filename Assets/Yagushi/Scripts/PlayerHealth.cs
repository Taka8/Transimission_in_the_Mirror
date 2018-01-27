using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : CharacterHealth
{

    private static PlayerHealth instance;
    
    public static PlayerHealth Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<PlayerHealth>();
            }

            return instance;
        }
    }

    [SerializeField] PlayerAnimator playerAnimator;

    void Reset()
    {
        playerAnimator = GetComponent<PlayerAnimator>();
    }
    
    public override void ApplyDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0) Death();
    }

    public override void Death()
    {
        playerAnimator.animateDeath();
    }
}
