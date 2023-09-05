using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ParticipantList : MonoBehaviour
{
    public TMP_Text participant;   
    public GameObject window;
    public GameObject[] NPC;

    private bool isOpen = false;
    public void participantBtn()
    {
        if (!isOpen)
        {
            window.SetActive(true);
            setName();
            isOpen = true;
        }
    }
    public void closeBtn()
    {
        if (isOpen)
        {
            window.SetActive(false);
            deleteName();
            isOpen = false;
        }
    }
    private void setName()
    {
        for (int i = 0; i < NPC.Length; i++)
        {
            participant.text +=  '\n'+NPC[i].name;
        }
        participant.text += '\n' + PlayerPrefs.GetString("PlayerName");
    }
    private void deleteName()
    {
        participant.text = "";
    }
}
