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
        foreach (Transform character in transform)
        {
            if(i == whichCharacter)
                character.gameObject.SetActive(true);
            else
                character.gameObject.SetActive(false);
            i++;
        }
    }
}
