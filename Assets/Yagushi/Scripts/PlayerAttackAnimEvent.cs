using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackAnimEvent : MonoBehaviour {

    public List<IApplicableDamage> applicablesList = new List<IApplicableDamage>();
    public PlayerWeaponManager playerWeapon;

    void AttackEvent()
    {
        ApplyDamage();
    }

    void ApplyDamage()
    {
        foreach(IApplicableDamage ad in applicablesList)
        {
            ad.ApplyDamage(playerWeapon.myWeapon.damage);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        IApplicableDamage ad = other.GetComponent<IApplicableDamage>();

        if (ad != null)
        {
            applicablesList.Add(ad);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        IApplicableDamage ad = other.GetComponent<IApplicableDamage>();

        if (ad != null)
        {
            applicablesList.Remove(ad);
        }
    }

}
