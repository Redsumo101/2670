using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Stats : ScriptableObject
{
    public float defense;
    public float jumpAmount;
    public float moveSpeed;
    public float attack;
    public float attackSpeed;

    public float GetStats()
    {
        return jumpAmount;


    }

}
