using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsBehavior : MonoBehaviour
{
    private float defense;
    public float jump;
    private float moveSpeed;
    private float attack;
    private float attackSpeed;
   [SerializeField] Stats startingStats;
     Stats stat;
    
    // Start is called before the first frame update
    void Start()
    {
        stat = startingStats;
        
    }

    // Update is called once per frame
    void Update()
    {
        ManageStats();
        Debug.Log(jump);
        Debug.Log(moveSpeed);
       
    }

    private void ManageStats()
    {
        
        var nextStats = stat.GetNextStats();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            stat = nextStats[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            stat = nextStats[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            stat = nextStats[2];
        }
       
        jump = stat.GetStats();
        moveSpeed = stat.GetStats();
    }
   
}
