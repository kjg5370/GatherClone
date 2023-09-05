using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameManager : MonoBehaviour
{
    public static gameManager I;

    public TMP_Text playerNameText;

    private void Awake()
    {
        I = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        // PlayerPrefs���� �÷��̾� �̸� ��������
        string playerName = PlayerPrefs.GetString("PlayerName");

        // UI�� �̸� ǥ��
        playerNameText.text = playerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
