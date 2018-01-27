using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{

    [SerializeField] Animator animator;
    public float velocity { get; private set; }
    public bool isAttacking { get; private set; }

    private void Reset()
    {
        animator = GetComponentInChildren<Animator>();
    }
    
    public void aanimateMove(float velocity)
    {
        this.velocity = velocity;
        animator.SetFloat("Velocity", velocity);
    }

    public void animateAttack(bool isAttacking)
    {
        this.isAttacking = isAttacking;
        animator.SetBool("Attack", isAttacking);
    }
    
}
