﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : CharacterHealth
{

    [SerializeField] PlayerAnimator playerAnimator;

    void Reset()
    {
        playerAnimator = GetComponent<PlayerAnimator>();    
    }

    public override void ApplyDamage(int damage)
    {
        currentHealth -= damage;
    }

    public override void Death()
    {
        playerAnimator.animateDeath();
    }
}
