using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.PlayerLoop;
using Debug = UnityEngine.Debug;

public class StatsBehavior : MonoBehaviour
{
    public float defense;
    public float jump;
    public float moveSpeed;
    public float attack;
    public float attackSpeed;
    public int whichCharacter = 0;
    public float sprint;
    public List<Stats> stats = new List<Stats>();

    private void Start()
    {
        ChangeCharacter();
    }

    private void Update()
    {
        {
            int previousCharacter = whichCharacter;
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                whichCharacter = 0;
                stats[0] = stats[3];
                CheckStats();
            }
            if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 2)
            {
                whichCharacter = 1;
                stats[0] = stats[1];
                CheckStats();
            }
            if (Input.GetKeyDown(KeyCode.Alpha3) && transform.childCount >= 3)
            {
                whichCharacter = 2;
                stats[0] = stats[2];
                CheckStats();
            }
            if (previousCharacter != whichCharacter)
            {
                ChangeCharacter();
            }
        }
        CheckStats();
    }

    void CheckStats()
    {
        if (stats[0] == true)
        {
            jump = stats[0].jumpAmount;
            moveSpeed = stats[0].moveSpeed;
            defense = stats[0].defense;
            attack = stats[0].attack;
            attackSpeed = stats[0].attackSpeed;
            sprint = stats[0].sprint;
        }
        else if (stats[1] == true)
        {
            jump = stats[1].jumpAmount;
            moveSpeed = stats[1].moveSpeed;
            defense = stats[1].defense;
            attack = stats[1].attack;
            attackSpeed = stats[1].attackSpeed;
            sprint = stats[1].sprint;
        }
        else if (stats[2] == true)
        {
            jump = stats[2].jumpAmount;
            moveSpeed = stats[2].moveSpeed;
            defense = stats[2].defense;
            attack = stats[2].attack;
            attackSpeed = stats[2].attackSpeed;
            sprint = stats[2].sprint;
        }
    }
    void ChangeCharacter()
    {
        int i = 0;
        foreach (Transform character in transform)
        {
            if(i == whichCharacter)
                character.gameObject.SetActive(true);
            else
                character.gameObject.SetActive(false);
            i++;
        }
    }
}
