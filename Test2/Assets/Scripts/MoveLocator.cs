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
   private void OnMouseDown()
   {
      var location = cam.ScreenToWorldPoint(Input.mousePosition);
      pointObj.position = location;
   }
}
