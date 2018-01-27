using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorAnimator : MonoBehaviour
{

    [SerializeField] PlayerAnimator playerAnimator;
    [SerializeField] Animator animator;

    void Reset()
    {
        animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        animator.SetFloat("Velocity", playerAnimator.velocity);
        animator.SetBool("Attack", playerAnimator.isAttacking);
    }

}
