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
    private int whichCharacter = 0;
    [SerializeField] Stats startingStats;
     Stats stat;
    
    // Start is called before the first frame update
    void Start()
    {
        stat = startingStats;
        
        ChangeCharacter();;

    }

    // Update is called once per frame
    void Update()
    {
        ManageStats();
        Debug.Log(jump);
       
    }

    private void ManageStats()
    {
        jump = stat.GetStats();
        var nextStats = stat.GetNextStats();
        int previousCharacter = whichCharacter;
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            stat = nextStats[0];
            whichCharacter = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 2)
        {
            stat = nextStats[1];
            whichCharacter = 1;
           
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) && transform.childCount >= 3)
        {
            stat = nextStats[2];
            whichCharacter = 2;
            
        }
        if (previousCharacter != whichCharacter)
        {
            ChangeCharacter();
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
