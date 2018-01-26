using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{

    [SerializeField] float moveSpeed;
    [SerializeField] Rigidbody rb;

    [SerializeField] Vector3 moveDirection;
    
    private void Reset()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Move(float h, float v, float deltaTime)
    {
        moveDirection.Set(h, 0, v);

        // 回転
        if (moveDirection != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(moveDirection,Vector3.up);
        }

        // 移動
        rb.MovePosition(transform.position + moveDirection * moveSpeed * deltaTime);

    }

}
