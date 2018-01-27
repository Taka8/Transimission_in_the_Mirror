using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Inventory/Weapon")]
public class WeaponItem : Item
{

    public int damage;
    public float force;
    public Sprite sprite;
    public Mesh mesh;
    public Material material;
    Vector3 offset;

    public override void Pickup()
    {
        
    }

}
