﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterBase : MonoBehaviour, IApplicableDamage {

    public abstract void ApplyDamage(int damage);

}
