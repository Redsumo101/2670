using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignBehaviour : MonoBehaviour
{
  public GameObject dialogueBox;
  public Text dialogueText;
  public string dialog;
  public bool dialogueActive;

  private void Start()
  {
    dialogueBox.SetActive(false);
    dialogueText.text = null;
  }


  private void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Player"))
    {
      dialogueBox.SetActive(true);
      dialogueActive = true;
      dialogueText.text = dialog;
    }
  }

  private void OnTriggerExit(Collider other)
  {
    if (other.CompareTag("Player"))
    {
      dialogueActive = false;
      dialogueBox.SetActive(false);
      dialogueText.text = null;
      
    }
  }
}
