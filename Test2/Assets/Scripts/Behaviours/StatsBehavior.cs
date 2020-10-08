using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsBehavior : MonoBehaviour
{
    private float defense;
    private float jumpAmount;
    private float moveSpeed;
    private float attack;
    private float attackSpeed;
    
    public Stats stats;
    public Stats stat;
    
    // Start is called before the first frame update
    void Start()
    {
        stat = stats;
        jumpAmount = stat.GetStats();
        Debug.Log(jumpAmount);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
