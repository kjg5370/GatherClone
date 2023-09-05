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

    public void OpenPanel()
    {
        ChooseChar.SetActive(true);
    }
    public void OnPenguinSelect()
    {
        DataManager.i.currentCharacter = Character.penguin;
        ChooseChar.SetActive(false);
         Knight.SetActive(false);
        Penguin.SetActive(true);
    }
    public void OnKnightnSelect()
    {
        DataManager.i.currentCharacter = Character.knight;
        ChooseChar.SetActive(false);
        Penguin.SetActive(false);
        Knight.SetActive(true);
    }
}
