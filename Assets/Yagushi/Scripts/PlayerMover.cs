using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{

    [SerializeField] float moveSpeed;
    [SerializeField] Rigidbody rb;
    [SerializeField] PlayerAnimator playerAnimator;

    Vector3 moveInput;

    private void Reset()
    {
        rb = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<PlayerAnimator>();
    }

    public void Move(float h, float v)
    {

        // 入力の値を保存
        moveInput.Set(h, 0, v);

        // 回転
        if (0 < moveInput.sqrMagnitude)
        {
            transform.rotation = Quaternion.LookRotation(moveInput.normalized);
        }

        float vy = rb.velocity.y;

        // 移動
        rb.velocity = transform.forward * moveSpeed * moveInput.magnitude + Vector3.up * vy;

        // アニメーション
        playerAnimator.aanimateMove(rb.velocity.magnitude);

    }

    public void Attack(bool isAttacking)
    {
        playerAnimator.animateAttack(isAttacking);
    }

}
