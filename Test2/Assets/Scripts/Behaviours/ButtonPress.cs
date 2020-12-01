using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
   public bool isPressed = false;
   /*public Animator press;*/

   private void OnTriggerEnter(Collider other)
   {
      if (other.CompareTag("Player"))
      {
         Debug.Log("Pressed");
         isPressed = true;
      }
   }
}
