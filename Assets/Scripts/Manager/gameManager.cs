using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class gameManager : MonoBehaviour
{
    public static gameManager I;

    public GameObject[] charPrefabs;
    public Actor[] NPC;
    public GameObject player;

    public DialogueController dialogueController;

    public TMP_Text participant;
    public TMP_Text timeTxt;
    private TMP_Text playerNameText;

    public bool isMoveBlocked = false;
    private void Awake()
    {
            I = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        SetUpPlayer(Vector3.zero);
    }

    // Update is called once per frame
    void Update()
    {
        playerNameText.text = PlayerPrefs.GetString("PlayerName");
        participant.text = "";
        for (int i = 0; i < NPC.Length; i++)
        {
            participant.text += '\n' + NPC[i].Name;
        }
        participant.text += '\n' + PlayerPrefs.GetString("PlayerName");

        timeTxt.text = DateTime.Now.ToString("tt HH:mm");
    }

    public void SetUpPlayer(Vector3 pos)
    {
        player = Instantiate(charPrefabs[(int)(DataManager.i.currentCharacter)],pos,Quaternion.identity);
        player.tag = "Player";
        playerNameText = player.transform.Find("Canvas/Name").GetComponent<TMP_Text>();

        MainCameraController mainCamera = Camera.main.GetComponent<MainCameraController>();
        mainCamera.player = player.transform;
    }
}
