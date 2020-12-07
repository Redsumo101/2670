using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BossDeath : MonoBehaviour
{
    public GameObject dialogueBox;
    public Text dialogueText;
    public string dialog;
    public bool bossDeath;
    // Start is called before the first frame update
    void Start()
    {
        bossDeath = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject == null && bossDeath == true)
        {
            StartCoroutine(Signs());
        }
    }

    IEnumerator Signs()
    {
        dialogueBox.SetActive(true);
        dialogueText.text = dialog;
        yield return new WaitForSeconds(3);
        dialogueBox.SetActive(false);
        dialogueText.text = null;
        bossDeath = false;
    }
}
