using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform PlayerTransform;

    private Vector3 cameraOffset;
    [Range(0.01f, 1.0f)]
    public float smoothFactor = 0.5f;

    public bool LookAtPlayer = false;
   

    private void Start()
    {
        cameraOffset = transform.position - PlayerTransform.position;
    }

    private void Update()
    {
        Vector3 newPos = PlayerTransform.position + cameraOffset;

        transform.position = Vector3.Slerp(transform.position, newPos, smoothFactor);
        
        if(LookAtPlayer)
            transform.LookAt(PlayerTransform);
    }

  
}
