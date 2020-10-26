using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingPlatform : MonoBehaviour
{
   private bool isOn;
   public GameObject platform;
   private Renderer rend;
   private Collider coli;
   public int repeatRate = 2;
   
 
   void Start()
   {
      rend = GetComponent<Renderer>();
      rend.enabled = true;
      coli = GetComponent<Collider>();
      coli.enabled = true;
      InvokeRepeating("OnAndOff", 0, repeatRate);
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
         rend.enabled = false;
         coli.enabled = false;
      }
      else
      {
         rend.enabled = true;
         coli.enabled = true;
      }
      
   }
}
