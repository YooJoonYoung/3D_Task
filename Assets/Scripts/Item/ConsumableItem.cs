using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsumableItem : MonoBehaviour
{
    public ItemData ItemData;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController playerController = other.GetComponent<PlayerController>();

            if (playerController != null)
            {
                Debug.Log("´ê¾ÒÀ½");
                playerController.SetSpeedMultiplier(2f, 5f);
                Destroy(gameObject);
            }
        }
    }
}
