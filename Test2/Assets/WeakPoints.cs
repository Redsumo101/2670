using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeakPoints : MonoBehaviour
{
   public float health;
   public float maxHealth;

   private void Start()
   {
      health = maxHealth;
   }

   public void TakeDamage(float damage)
   {
      health -= damage;

      if (health <= 0)
      {
         Die();
      }

      void Die()
      {
         Destroy(gameObject);
      }
   }
}
