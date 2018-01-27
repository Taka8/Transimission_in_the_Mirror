using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterHealth : MonoBehaviour, IApplicableDamage
{

    public int maxHealth { get; protected set; }
    public int currentHealth { get; protected set; }

    public abstract void ApplyDamage(int damage);

    public abstract void Death();

}
