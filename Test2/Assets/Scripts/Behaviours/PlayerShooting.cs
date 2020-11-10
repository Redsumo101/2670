using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public int ammoCount = 30;
    public GameObject prefab;
    public WaitForSeconds reloadTime;
    public Transform instancer;
    // Start is called before the first frame update
    void Start()
    {
        reloadTime = new WaitForSeconds(2); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && ammoCount > 0)
        {
            StartCoroutine(Fire());
        }
    }

    private IEnumerator Fire()
    {
        Instantiate(prefab, instancer.position, instancer.rotation);
        ammoCount--;

        if (ammoCount == 0)
        {
            yield return reloadTime;
            ammoCount = 30;
        }
    }
    
}
