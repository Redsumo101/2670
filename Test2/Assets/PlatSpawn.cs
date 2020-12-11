using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatSpawn : MonoBehaviour
{
    public GameObject prefab;
    public Vector3[] positions;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Spawned");
        }
    }
}
