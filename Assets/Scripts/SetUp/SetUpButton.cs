using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class SetUpButton : MonoBehaviour
{
    [SerializeField] private InputField playerNameInput;
    private string playerName = null;

    public void InputName()
    {
        playerName = playerNameInput.GetComponent<InputField>().text;
        if (playerName.Length > 1)
        {
            PlayerPrefs.SetString("PlayerName", playerName);
            SceneManager.LoadScene("MainScene");
        }
        else playerNameInput.text = "";
    }
   
}
