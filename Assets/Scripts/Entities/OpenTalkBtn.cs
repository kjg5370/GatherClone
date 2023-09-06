using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTalkBtn : MonoBehaviour
{
    public Transform player; // player Transform
    public GameObject TalkBtn; // ��ȭ ��ư
    public GameObject Panel;
    public float activationDistance = 7f; // ��ȭ ��ư�� Ȱ��ȭ�� �Ÿ�

    [SerializeField] DialogueContainer dialogue;

    private void Update()
    {
        player = gameManager.I.player.transform;
        // �÷��̾�� Ʃ�� ���� �Ÿ� ���
        float distance = Vector3.Distance(transform.position, player.position);

        // �Ÿ��� ���� �Ÿ� �̳��� ��� ��ȭ ��ư�� Ȱ��ȭ
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
