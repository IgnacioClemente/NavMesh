using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour { 
    
    [SerializeField] Transform[] DestinationPoints;

    Transform actualDestination;
    NavMeshAgent agent;

    //elegir un destino aleatorio y sitearlo como el destino actual, calcular la distancia al destino actual y cuando llego elegir un nuevo destino aleatoria
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        ChooseNewDestination();
    }

    void Update()
    {
        var distance = Vector3.Distance(transform.position, actualDestination.position);
        print(distance);
        if (distance < 0.8f)
            ChooseNewDestination();
    }

    public void ChooseNewDestination()
    {
        int rdm = Random.Range(0, DestinationPoints.Length);
        actualDestination = DestinationPoints[rdm];
        agent.SetDestination(actualDestination.position);
    }
}
