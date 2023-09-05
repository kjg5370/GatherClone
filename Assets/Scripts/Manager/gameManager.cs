using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameManager : MonoBehaviour
{
    public static gameManager I;

    public GameObject[] charPrefabs;
    public GameObject player;
    //public TMP_Text playerNameText;

    private void Awake()
    {
            I = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        player = Instantiate(charPrefabs[(int)(DataManager.i.currentCharacter)]);
        TMP_Text playerNameText = player.transform.Find("Canvas/Name").GetComponent<TMP_Text>();

        playerNameText.text = PlayerPrefs.GetString("PlayerName");
        MainCameraController mainCamera = Camera.main.GetComponent<MainCameraController>();
        mainCamera.player = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
