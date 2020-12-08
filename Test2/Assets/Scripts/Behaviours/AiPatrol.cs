using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;


[RequireComponent(typeof(NavMeshAgent))]
public class AiPatrol : MonoBehaviour
{
    [SerializeField]
    Transform[] points;
    NavMeshAgent agent;
    private int randomSpot;
    private int randomStuff;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        agent.autoBraking = false;

        GoToNextPoint();
        randomStuff = Random.Range(1, 2);
    }

    void GoToNextPoint()
    {
        if (points.Length == 0)
        {
            return;
        }

        agent.destination = points[randomSpot].position;
        randomSpot = (randomSpot + 1) % points.Length;
    }

    private void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            GoToNextPoint();
        }
    }
}
