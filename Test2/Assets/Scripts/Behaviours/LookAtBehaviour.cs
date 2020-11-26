using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtBehaviour : MonoBehaviour
{
    private Camera mainCamera;

    private void Start()
    {
        mainCamera = FindObjectOfType<Camera>();
    }

    private void Update()
    {
        Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, transform.position);
        float rayLength;

        if (groundPlane.Raycast(cameraRay, out rayLength))
        {
            Vector3 pointToLook = cameraRay.GetPoint(rayLength);
            
            transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));
        }
    }
}
