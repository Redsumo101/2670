using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BossSpawn : MonoBehaviour
{
    public List<ButtonPress> buttons;

    void Update()
    {
        if (buttons[0].isPressed == true && buttons[1].isPressed == true && buttons[2].isPressed == true)
        {
            Debug.Log("Please");
        }
    }
}
