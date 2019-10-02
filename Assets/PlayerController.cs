using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Transform pos;
    [SerializeField] NavMeshAgent agent;
    [SerializeField] Transform[] DestinationPoints;

    void Start()
    {
        agent.SetDestination(pos.position);
    }

    void Update()
    {
        Patrol();
    }

    public void Patrol()
    {
        for (int i = 0; i < DestinationPoints.Length; i++)
        {
            agent.SetDestination(DestinationPoints[i].position);
        }
    }
}
