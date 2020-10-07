using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstancerBehaviour : MonoBehaviour
{

    public GameObject prefab;
    public Vector3Data rotationDirection;
    public float force = 30f;
    public void Instance()
    {
            var location = transform.position;
     
            //Spawns bullets
            var newObj = Instantiate(prefab, location, Quaternion.Euler(rotationDirection.value));

           
        



    }

  
}

    
        
    
