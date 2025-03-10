using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    private static readonly int IsWalking = Animator.StringToHash("IsWalking");

    protected Animator animator;

    protected virtual void Awake()
    {
        animator = GetComponent<Animator>();  
    }
    public void Walk(Vector3 obj)
    {
        animator.SetBool(IsWalking, obj.magnitude> 1f);
    }
}
