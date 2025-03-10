using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpZone : MonoBehaviour
{
    public float jumpMultiplier = 5f;  // ���� 5��

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Player �±� ������Ʈ�� ����
        {
            PlayerController playerController = collision.gameObject.GetComponent<PlayerController>(); // PlayerController ã��
            if (playerController != null)
            {
                playerController.SetJumpMultiplier(jumpMultiplier); // ���� ���� ����
                playerController.ForceJump(); //��������
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        // �÷��̾ JumpZone���� ���� �� ���� ���� �ʱ�ȭ
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerController playerController = collision.gameObject.GetComponent<PlayerController>();
            if (playerController != null)
            {
                playerController.ResetJumpMultiplier(); // ���� ���� �ʱ�ȭ
            }
        }
    }
}

