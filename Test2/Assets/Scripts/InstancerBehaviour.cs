using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstancerBehaviour : MonoBehaviour
{

    public GameObject prefab;
    public Vector3Data rotationDirection;
    public float force = 30f;
    public void Update()
    {
        var location = transform.position;
        //Shoots prefabs after pressing the mouse button in the shooting form in unity
        if (Input.GetMouseButtonDown(0))
        {
            //Spawns bullets
           var rotationDirection = new Vector3(force,0f, 0f);
           Instantiate(prefab, location, Quaternion.Euler(rotationDirection));

           
        }



    }

  
}

    
        
    
