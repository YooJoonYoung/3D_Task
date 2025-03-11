using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCamera : MonoBehaviour
{
    public Camera rayCamera; // 카메라 객체
    public float rayDistance = 4f; // 레이의 거리
    public LayerMask playerLayer; // 플레이어 레이어 (Player 오브젝트만 충돌 감지)
    private bool isRayHit = false;

    void Update()
    {
        //Ray ray = rayCamera.ScreenPointToRay(rayCamera.WorldToScreenPoint(transform.position));
        

        RaycastHit hit;

    
        if (Physics.Raycast(new Ray(transform.position, Vector3.back), out hit, rayDistance, playerLayer))
        {

            if (!isRayHit) // 레이가 처음 충돌한 경우에만 메시지 출력
            {
                Debug.Log("Player가 레이에 닿았습니다!");
                isRayHit = true; // 충돌 상태로 설정
            }

        }
        else
        {
            // 레이가 충돌하지 않으면 isRayHit 상태를 초기화
            isRayHit = false;
        }

    }
    //private void FixedUpdate()
    //{
    //    // 카메라에서 발사되는 레이
    //    Ray ray = rayCamera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0)); // 화면 중앙에서 레이를 발사

    //    // 충돌 감지
    //    RaycastHit hit;
    //    if (Physics.Raycast(ray, out hit, rayDistance, playerLayer))
    //    {
    //        // 플레이어와 충돌 시 레이의 끝 지점을 플레이어의 충돌 지점으로 설정
    //        Debug.DrawRay(ray.origin, ray.direction * hit.distance, Color.red);  // 레이의 길이를 충돌 지점까지 설정
    //    }
    //    else
    //    {
    //        // 충돌하지 않으면 지정된 거리만큼 레이를 그림
    //        Debug.DrawRay(ray.origin, ray.direction * rayDistance, Color.red);
    //    }
    //}
}
