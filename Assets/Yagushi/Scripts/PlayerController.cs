using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMover))]
public class PlayerController : MonoBehaviour
{

    [SerializeField] PlayerMover playerMover;

    float hInput;
    float vInput;

    private void Reset()
    {
        playerMover = GetComponent<PlayerMover>();
    }

    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        playerMover.Attack(Input.GetButton("Fire1"));
    }

    private void FixedUpdate()
    {
        playerMover.Move(hInput, vInput);
    }

}
