using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtBehaviour : MonoBehaviour
{
   public void OnLook(Vector3Data obj)
   {
      var y = obj.value.y + 90f;
      Vector3 newLoc = Vector3.zero;
      newLoc.Set(0,y,0);
      transform.LookAt(newLoc);
   }
}
