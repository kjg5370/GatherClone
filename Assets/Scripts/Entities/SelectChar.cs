using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SelectChar : MonoBehaviour
{
    public GameObject ChooseChar;
    public GameObject Penguin;
    public GameObject Knight;

    private Vector3 playerPos = Vector3.zero;
    public void OpenPanel()
    {
        if(gameManager.I != null)gameManager.I.isMoveBlocked = true;
        ChooseChar.SetActive(true);
    }
    private void SelectCharacter(Character selectedCharacter)
    {
        DataManager.i.currentCharacter = selectedCharacter;
        ChooseChar.SetActive(false);
        if (gameManager.I == null)
        {
            Penguin.SetActive(selectedCharacter == Character.penguin);
            Knight.SetActive(selectedCharacter == Character.knight);
        }
        else if(gameManager.I.player != null)
        {
            GameObject player = gameManager.I.player;
            playerPos = player.transform.position;
            Destroy(player);
            gameManager.I.SetUpPlayer(playerPos);
            gameManager.I.isMoveBlocked = false;
        }
    }
    public void OnPenguinSelect()
    {
        SelectCharacter(Character.penguin);
    }
    public void OnKnightSelect()
    {
        SelectCharacter(Character.knight);
    }
}
