using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ParticipantList : MonoBehaviour
{
    public GameObject window;
    private bool isOpen = false;
    public void participantBtn()
    {
        if (!isOpen)
        {
            window.SetActive(true);
            isOpen = true;
        }
    }
    public void closeBtn()
    {
        if (isOpen)
        {
            window.SetActive(false);
            isOpen = false;
        }
    }
}
