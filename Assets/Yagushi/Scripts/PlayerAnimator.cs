using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{

    [SerializeField] Animator[] animators;

    public void animateMove(float velocity)
    {
        foreach (Animator a in animators)
        {
            a.SetFloat("Velocity", velocity);
        }
    }

    public void animateAttack(bool isAttacking)
    {
        foreach (Animator a in animators)
        {
            a.SetBool("Attack", isAttacking);
        }
    }

    public void animateDeath()
    {
        foreach (Animator a in animators)
        {
            a.SetTrigger("Death");
        }
    }

}
