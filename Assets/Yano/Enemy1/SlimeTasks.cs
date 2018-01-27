using UnityEngine;
using System.Collections;
using Panda;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class SlimeTasks : MonoBehaviour
{
    NavMeshAgent m_Agent;

    void Start()
    {
        m_Agent = GetComponent<NavMeshAgent>();
    }

    [Task]
    void MoveToPlayer()
    {
        GameObject player = GameObject.Find("Player");
        m_Agent.destination = player.transform.position;

        //rend.material.color = new Color(r, g, b);
        //Task.current.Succeed(); // <-- Task.current gives access to the run-time task bind to this method.
    }
}
