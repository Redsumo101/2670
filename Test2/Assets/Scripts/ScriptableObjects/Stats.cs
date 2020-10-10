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
    public Stats[] nextStats;

    public float GetStats()
    {
        return jumpAmount;

    }

    public Stats[] GetNextStats()
    {
        return nextStats;
    }

}
