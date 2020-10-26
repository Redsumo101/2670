using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Respawn : MonoBehaviour
{
    public GameObject RestartMenu;
    public GameObject player;

    

    

    public void Update()
    {
        if (!player)
        {
            RestartMenu.SetActive(true);
        }
        else
        {
            RestartMenu.SetActive(false);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
   
    
   
   
}
