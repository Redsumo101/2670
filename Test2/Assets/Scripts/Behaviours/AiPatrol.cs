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
    public float distance;
    public LineRenderer lineOfSight;
    public Gradient redColor;
    public Gradient greenColor;
    public GameObject player;


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
        RaycastHit hitInfo;
        if (Physics.Raycast(transform.position, transform.forward, out hitInfo, distance));
        {
            if (hitInfo.collider != null)
            {
                Debug.DrawLine(transform.position, hitInfo.point, Color.red);
                lineOfSight.SetPosition(1, hitInfo.point);
                if (hitInfo.collider.gameObject.CompareTag("Player"))
                {
                    agent.destination = player.transform.position;
                    lineOfSight.colorGradient = redColor;
                   
                }
                else
                {
                    lineOfSight.colorGradient = greenColor;
                }
            }
            else
            {
                Debug.DrawLine(transform.position, transform.position + transform.forward * distance, Color.green);
                lineOfSight.SetPosition(1, transform.position + transform.forward * distance);
                lineOfSight.colorGradient = greenColor;
            }
        }
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            GoToNextPoint();
        }
        
        lineOfSight.SetPosition(0,transform.position);
    }
}
