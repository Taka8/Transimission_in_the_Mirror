﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Inventory/Weapon")]
public class WeaponItem : Item
{

    public int damageAmout;
    public Sprite sprite;
    public Mesh mesh;

    public override void Use()
    {
        
    }

}
