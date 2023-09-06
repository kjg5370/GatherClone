using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTalkBtn : MonoBehaviour
{
    public Transform player; // player Transform
    public GameObject TalkBtn; // 대화 버튼
    public GameObject Panel;
    public float activationDistance = 7f; // 대화 버튼을 활성화할 거리

    [SerializeField] DialogueContainer dialogue;

    private void Update()
    {
        player = gameManager.I.player.transform;
        // 플레이어와 튜터 간의 거리 계산
        float distance = Vector3.Distance(transform.position, player.position);

        // 거리가 일정 거리 이내인 경우 대화 버튼을 활성화
        if (distance <= activationDistance && !Panel.activeSelf)
        {
            TalkBtn.gameObject.SetActive(true);
        }
        else
        {
            TalkBtn.gameObject.SetActive(false);
        }
    }
    public void Show()
    {
        TalkBtn.SetActive(false);
        Panel.SetActive(true);
        gameManager.I.dialogueController.Initialize(dialogue);
    }
}
