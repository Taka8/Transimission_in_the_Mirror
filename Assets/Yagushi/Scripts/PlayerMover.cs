using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{

    [SerializeField] float moveSpeed;
    [SerializeField] Rigidbody rb;

    Vector3 moveDirection;

    private void Reset()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Move(float h, float v, float deltaTime)
    {
        moveDirection.Set(h, 0, v);

        rb.MovePosition(transform.position + moveDirection * moveSpeed * deltaTime);
    }

}
