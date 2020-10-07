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
    
    // Start is called before the first frame update
    void Start()
    {
        jumpAmount = stats.jumpHeight;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
