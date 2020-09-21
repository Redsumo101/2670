using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLocator : MonoBehaviour
{
   private Camera cam;
   public Transform pointObj;
   private void Start()
   {
      cam = Camera.main;
   }
   private void Move()
   {
      if (Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition)))
      {
         
      }
   }
}
