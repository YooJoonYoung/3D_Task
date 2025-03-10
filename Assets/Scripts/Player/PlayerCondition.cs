using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;

public class PlayerCondition : MonoBehaviour
{
    public UICondition uiCondition;

    Condition health { get { return uiCondition.health; } }

    Condition stamina { get { return uiCondition.stamina; } }

    void Update()
    {
        health.Subtract(health.passiveValue * Time.deltaTime);
        stamina.Add(stamina.passiveValue * Time.deltaTime);

       
        if (health.curValue == 0f)
        {
            Debug.Log("ав╬З╢ы");
        }
    }
    public void Heal(float amount)
    {
        health.Add(amount);
    }

   
}
