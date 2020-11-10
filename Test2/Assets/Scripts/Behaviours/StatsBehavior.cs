using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class StatsBehavior : MonoBehaviour
{
    private float defense;
    public float jump;
    private float moveSpeed;
    private float attack;
    private float attackSpeed;
    //public ScriptableObject[] stats;

   
    public List<Stats> stats = new List<Stats>();
    private void Update()
    {
        CheckStats();
    }

    void CheckStats()
    {
        if (stats[0] == true)
        {
            jump = stats[0].jumpAmount;
            Debug.Log(jump);
        }
    }
}
