﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class ApplyForce : MonoBehaviour
{
    private Rigidbody rBody;

    public float force = 30f;
    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
        var forceDirection = new Vector3(force, 0,0);
        rBody.AddRelativeForce(forceDirection);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
