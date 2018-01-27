using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactables : MonoBehaviour
{

    public bool interactable = false;

    public Material[] material;
    public Renderer rend;

    void Start()
    {
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    public virtual void Interact()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        if (interactable && Input.GetButtonDown("Fire1"))
        {
            Interact();
        }
        if (interactable)
        {
            rend.sharedMaterial = material[1];
        }
        else
        {
            rend.sharedMaterial = material[0];
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>())
        {
            interactable = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Player>())
        {
            interactable = false;
        }
    }
}
