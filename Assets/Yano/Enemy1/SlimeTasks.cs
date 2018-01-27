using UnityEngine;
using System.Collections;
using Panda;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class SlimeTasks : MonoBehaviour
{
    NavMeshAgent m_Agent;
    public SimpleAnimationController sac;

    void Start()
    {
        m_Agent = GetComponent<NavMeshAgent>();
    }

    [Task]
    void MoveToPlayer()
    {
        GameObject player = GameObject.Find("Player");
        m_Agent.destination = player.transform.position;

        sac.DoAction(SimpleAnimationController.Actions.Move);

        Task.current.Succeed();
    }

    [Task]
    void Idle()
    {
        //GameObject player = GameObject.Find("Player");
        m_Agent.destination = transform.position; //player.transform.position;

        sac.DoAction(SimpleAnimationController.Actions.Idle);

        Task.current.Succeed();
    }

    [Task]
    void Attack()
    {
        //GameObject player = GameObject.Find("Player");
        m_Agent.destination = transform.position + Vector3.left;

        sac.DoAction(SimpleAnimationController.Actions.Attack);

        Task.current.Succeed();
    }
}
