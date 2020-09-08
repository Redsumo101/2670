using System;
using UnityEngine;

public class SwitchCharacters : MonoBehaviour
{
    public int whichCharacter = 0;
    
    void Start()
    {
        ChangeCharacter();
    }

    private void Update()

    {
        int previousCharacter = whichCharacter;
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            whichCharacter = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 2)
        {
            whichCharacter = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && transform.childCount >= 3)
        {
            whichCharacter = 2;
        }
        if (previousCharacter != whichCharacter)
        {
            ChangeCharacter();
        }
    }

    void ChangeCharacter()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if(i == whichCharacter)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);
            i++;
        }
    }
}
