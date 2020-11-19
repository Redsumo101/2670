using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparentBehavior : MonoBehaviour
{
   public Material transMat;
   public Material ogMat;
   private MeshRenderer mesh;

   private void Start()
   {
      mesh = GetComponent<MeshRenderer>();
      mesh.material = ogMat;
   }

   public void SetTransparent()
   {
      mesh.material = transMat;
   }

   public void Normal()
   {
      mesh.material = ogMat;
   }
   
}
