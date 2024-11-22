using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPCDialogue : MonoBehaviour
{
    public string[] dialogueNPC;
    public int dialogueIndex;

    public GameObject dialoguePanel;
    public TextMeshProUGUI dialogueText;

    public TextMeshProUGUI nameNpc;
    public Image imageNPC;
    public Sprite spriteNpc;

    public bool readyToSpeak;
    public bool startDialogue;
    void Start()
    {
        dialoguePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && readyToSpeak)
        {
            if (!startDialogue)
            {
                FindObjectOfType<Player>().speed = 0f;
                StartDialogue();
            }
            else if(dialogueText.text == dialogueNPC[dialogueIndex])
            {
                NextDialogue();
            }
        }
    }

    void NextDialogue()
    {
        dialogueIndex++;

        if(dialogueIndex < dialogueNPC.Length)
        {
            StartCoroutine(ShowDialogue());
        }
        else
        {
            dialoguePanel.SetActive(false);
            startDialogue = false;
            dialogueIndex = 0;
            FindObjectOfType<Player>().speed = 5f;
        }
    }

    void StartDialogue()
    {
        nameNpc.text = "Marcos";
        imageNPC.sprite = spriteNpc;
        startDialogue = true;
        dialogueIndex = 0;
        dialoguePanel.SetActive(true);
        StartCoroutine(ShowDialogue());
    }

    IEnumerator ShowDialogue()
    {
        dialogueText.text = "";
        foreach(char letter in dialogueNPC[dialogueIndex])
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.1f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            readyToSpeak = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            readyToSpeak = false;
        }
    }
}
