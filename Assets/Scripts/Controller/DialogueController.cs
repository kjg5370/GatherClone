using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueController : MonoBehaviour
{
    [SerializeField] TMP_Text targetText;
    [SerializeField] TMP_Text nameText;
    [SerializeField] Image portrait;
    [SerializeField] Actor NPC;
    DialogueContainer currentDialogue;
    
    int currentTextLine;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PushText();
        }
    }

    private void PushText()
    {
        currentTextLine += 1;
        if (currentTextLine >= currentDialogue.line.Count)
        {
            Conclude();
        }
        else
        {
            targetText.text = currentDialogue.line[currentTextLine];
        }
    }
    public void Initialize(DialogueContainer dialogueContainer)
    {
        currentDialogue = dialogueContainer;
        currentTextLine = 0;
        targetText.text = currentDialogue.line[currentTextLine];
        nameText.text = NPC.Name;
        portrait.sprite = NPC.portrait;
    }

    private void Conclude()
    {
        gameManager.I.isMoveBlocked = false;
        gameObject.SetActive(false);
    }
}
