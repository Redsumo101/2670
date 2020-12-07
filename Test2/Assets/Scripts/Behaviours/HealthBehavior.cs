using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBehavior : MonoBehaviour

{
    public float maxHealth = 10;
    public float health;
    public HealthBar healthBar;
    public void Start()
    {
        health = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }


    private void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            health --;
            healthBar.SetHealth(health);
        }
        if(other.CompareTag("WeakPoints"))
        {
            health--;
            healthBar.SetHealth((health));
        }
    }

    public void GetHealth(float plus)
    {
        health += plus;
        healthBar.SetHealth(health);
    }
}
