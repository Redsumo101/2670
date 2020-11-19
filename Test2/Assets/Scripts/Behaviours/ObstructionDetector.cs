using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstructionDetector : MonoBehaviour
{
    public Transform player;
    private TransparentBehavior obstruction;
    
    
    void Start()
    {
        StartCoroutine(DetectObstruction());
    }



    IEnumerator DetectObstruction()
    {
        while (true)
        {
            Vector3 origin = Camera.current.transform.position;
            Vector3 direction = player.forward;
            Ray ray = new Ray(origin, direction);
            yield return new WaitForSeconds(0.5f);


            if (Physics.Raycast(ray, out RaycastHit raycastHit, Mathf.Infinity))
            {
                obstruction = raycastHit.collider.gameObject.GetComponent<TransparentBehavior>();
                if (obstruction)
                {
                    obstruction.SetTransparent();
                }
                else
                {
                    obstruction.Normal();
                }
            }
        }
    }
}
