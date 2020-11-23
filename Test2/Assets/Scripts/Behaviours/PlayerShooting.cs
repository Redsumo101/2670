using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShooting : MonoBehaviour
{
    public Text uiAmmo;
    public int maxAmmo = 30;
    public int currentAmmo;
    public GameObject prefab;
    public WaitForSeconds reloadTime;
    public Transform instancer;

    public Text reload;
    // Start is called before the first frame update
    void Start()
    {
        reloadTime = new WaitForSeconds(2);
        currentAmmo = maxAmmo;
        reload.GetComponent<Text>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Fire1") && currentAmmo> 0)
        {
            Fire();
        }
        if (uiAmmo != null)
        {
            uiAmmo.text = currentAmmo.ToString();
        }
        
        if (Input.GetKeyDown("r") || currentAmmo <= 0)
        {
            StartCoroutine(Reload());
        }
    }

    void Fire()
    {
        Instantiate(prefab, instancer.position, instancer.rotation);
        currentAmmo--;
    }

    IEnumerator Reload()
    {
        if (currentAmmo <= 0 || Input.GetKeyDown("r") )
        {
            reload.GetComponent<Text>().enabled = true;
            yield return reloadTime;
            currentAmmo = maxAmmo;
            reload.GetComponent<Text>().enabled = false;
        }
       
    }
    
}
