using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingPlatform : MonoBehaviour
{
    public Transform platformPosition;
    public GameObject platform;
    public int gone = 2;
    public WaitForSeconds goneTime;

    void Start()
    {
        goneTime = new WaitForSeconds(3);
    }

    private void Update()
    {
        StartCoroutine(Destroy());
    }

    private IEnumerator Destroy()
    {
        yield return goneTime;
        Destroy(gameObject);

    }
    void OnDestroy()
    {
        StartCoroutine(Disappear());
    }

   private IEnumerator Disappear()
   {
       Instantiate(platform, platformPosition.position, platformPosition.rotation);
       yield return goneTime;
   }
}
