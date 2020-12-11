using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingPlatform : MonoBehaviour
{
   private bool isOn;
   private Renderer rend;
   private Collider coli;
   public int repeatRate = 2;
   public Material seeThrough;
   public Material solid;
   
   
 
   void Start()
   {
      rend = GetComponent<Renderer>();
      rend.enabled = true;
      coli = GetComponent<Collider>();
      coli.enabled = true;
      InvokeRepeating("OnAndOff", 0, repeatRate);
      gameObject.GetComponent<MeshRenderer>().material = solid;
   }
 
   void OnAndOff()
   {
      if(isOn){
         isOn = false;
      }else{
         isOn = true;
      }
   }

   private void Update()
   {
      if (isOn == false)
      {
         gameObject.GetComponent<MeshRenderer>().material = seeThrough;
         coli.enabled = false;
      }
      else
      {
         gameObject.GetComponent<MeshRenderer>().material = solid;
         coli.enabled = true;
      }
      
   }

 
}
