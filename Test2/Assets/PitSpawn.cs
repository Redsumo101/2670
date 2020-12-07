using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitSpawn : MonoBehaviour
{
    public GameObject player;
    public Transform spawnLocation;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.transform.position = spawnLocation.transform.position;
           
        }
    }
}
