using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancer : MonoBehaviour
{

    public GameObject prefab;

    public void Update()
    {
        var location = transform.position;
        //Shoots prefabs after pressing the mouse button in the shooting form in unity
        if (Input.GetMouseButtonDown(0))
        {
            //Spawns bullets
            Instantiate(prefab, location, Quaternion.identity);

           
        }



    }

  
}

    
        
    
