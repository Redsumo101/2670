using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBegin : MonoBehaviour
{
   public GameObject prefab;
   public Transform spawnPoint;

   private void OnTriggerEnter(Collider other)
   {
      if (other.CompareTag("Player"))
      {
         Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
      }
   }
}
