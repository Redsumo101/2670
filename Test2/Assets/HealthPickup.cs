using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{ 
   public float health = 5f;

   private void OnTriggerEnter(Collider player)
   {
      player.GetComponent<HealthBehavior>().GetHealth(health);
      Destroy(gameObject);
   }
}
