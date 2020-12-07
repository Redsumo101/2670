using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class BossBehaviour : MonoBehaviour
{
  public List<WeakPoints> weakSpots;
  public Transform head;
  public GameObject prefab;
  private bool spawn = false;
  public GameObject clone;
  

  public void Update()
  {
    if (weakSpots[0] == null && weakSpots[1] == null && weakSpots[2] == null && spawn == false)
    {
      LastHit();
      
    }

    if (spawn == true)
    {
      CloneCheck();
    }

  }

  void LastHit()
  {
      clone = (GameObject) Instantiate(prefab, head.position, head.rotation);
      spawn = true;
      
      
      
  }

  void CloneCheck()
  {
    if (clone == null)
    {
      Destroy(gameObject);
    }
  }
 
  
}
