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
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(prefab, location, Quaternion.identity);

           
        }



    }

  
}

    
        
    
