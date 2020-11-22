using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ObstructionDetector : MonoBehaviour
{
    public Material seeThrough;
    public Camera camera;
    public Transform target;
    public LayerMask layerMask;
    private Material defaultMaterial;

    private Transform selected;


    private void Start()
    {
        
    }

    private void OnValidate()
    {
        if (camera == null)
            camera = Camera.main;
    }

    private void Update()
    {
        RaycastSingle();
    }

    private void RaycastSingle()
    {
        Vector3 origin = camera.transform.position;
        Vector3 toPosition = target.transform.position;
        Vector3 direction = toPosition - origin;

        if (selected != null)
        {
            var selectionRenderer = selected.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial;
            selected = null;
        }
        
        Debug.DrawRay(origin, direction * 10f, Color.red);
        Ray ray = new Ray(origin, direction);
        
        if (Physics.Raycast(ray, out RaycastHit raycastHit, 50f, layerMask))
        {
            var selection = raycastHit.transform;
            var selectionRenderer = selection.GetComponent<Renderer>();
            if (selectionRenderer != null)
            {
                raycastHit.collider.GetComponent<Renderer>().material = seeThrough;
            }

            selected = selection;
        }
    }
}
