using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BossSpawn : MonoBehaviour
{
    public List<ButtonPress> buttons;
    public GameObject boss;
    public Transform spawnPoint;
    public GameObject dialogueBox;
    public Text dialogueText;
    public string dialog;

    private void Start()
    {
        dialogueText.text = null;
    }


    void Update()
    {
        if (buttons[0].isPressed == true && buttons[1].isPressed == true && buttons[2].isPressed == true)
        {
            Instantiate(boss, spawnPoint.transform);
            StartCoroutine(Sign());
            buttons[0].isPressed = false;
        }
    }

    IEnumerator Sign()
    {
        dialogueBox.SetActive(true);
        dialogueText.text = dialog;
        yield return new WaitForSeconds(3);
        dialogueBox.SetActive(false);
        dialogueText.text = null;
    }
}
