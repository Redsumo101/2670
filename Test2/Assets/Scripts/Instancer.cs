using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancer : MonoBehaviour
{
   
    public GameObject prefab;
    private void Start()
    {
        var location = transform.position;
        Instantiate(prefab, location, Quaternion.identity);
       
    }
    
}
