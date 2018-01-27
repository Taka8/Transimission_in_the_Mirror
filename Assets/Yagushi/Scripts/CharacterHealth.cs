using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterHealth : MonoBehaviour, IApplicableDamage
{

    public int maxHealth;
    protected int currentHealth;

    public abstract void ApplyDamage(int damage);
    public abstract void Death();

}
