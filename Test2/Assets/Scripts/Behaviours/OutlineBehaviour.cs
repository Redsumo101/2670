using System.Collections;
using System.Collections.Generic;
using cakeslice;
using UnityEngine;

public class OutlineBehaviour : MonoBehaviour
{
    public Outline playerOutline;

    private void Start()
    {
        playerOutline.enabled = false;
    }

    private void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, 100f, LayerMask.GetMask("Ground")))
        {
            playerOutline.enabled = true;
        }
        else 
        {
            playerOutline.enabled = false;
        }
    }
}
