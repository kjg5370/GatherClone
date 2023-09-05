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
        // PlayerPrefs에서 플레이어 이름 가져오기
        string playerName = PlayerPrefs.GetString("PlayerName");

        // UI에 이름 표시
        playerNameText.text = playerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
