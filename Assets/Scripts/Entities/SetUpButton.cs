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

    public GameObject EnterName;

    private string playerName = null;
    private Scene currentScene;
    private void Start()
    {
        // 현재 활성화된 씬의 정보 가져오기
        currentScene = SceneManager.GetActiveScene();
    }
    public void InputName()
    {
        playerName = playerNameInput.GetComponent<InputField>().text;
        if (playerName.Length > 1)
        {
            PlayerPrefs.SetString("PlayerName", playerName);
            if (currentScene.name == "SetupScene") SceneManager.LoadScene("MainScene");
            EnterName.SetActive(false);
        }
        else playerNameInput.text = "";
    }

    public void ChangeName()
    {
        EnterName.SetActive(true);
    }
}
