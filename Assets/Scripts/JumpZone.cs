using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpZone : MonoBehaviour
{
    public float jumpMultiplier = 5f;  // 점프 5배

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Player 태그를 가진 오브젝트만 반응하도록 설정
        {
            PlayerController playerController = collision.gameObject.GetComponent<PlayerController>(); // PlayerController 찾기
            if (playerController != null)
            {
                playerController.SetJumpMultiplier(jumpMultiplier); // 점프 배율 설정
                playerController.ForceJump();
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        // 플레이어가 JumpZone에서 나갈 때 점프 배율을 초기화
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerController playerController = collision.gameObject.GetComponent<PlayerController>();
            if (playerController != null)
            {
                playerController.ResetJumpMultiplier(); // 점프 배율 초기화
            }
        }
    }
}

