using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAnemationParameterControl : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        EventHandler.MovementEvent += SetAnimationParameters;
    }

    private void OnDisable()
    {
        EventHandler.MovementEvent += SetAnimationParameters;
    }

    private void SetAnimationParameters(float xInput, float yInput, bool isWalking, bool isRunning, bool isIdle,
        bool isCarrying, ToolEffect toolEffect, bool isUsingToolLeft, bool isUsingToolRight, bool isUsingToolDown,
        bool isUsingToolUp, bool isLiftingToolDown, bool isLiftingToolLeft, bool isLiftingToolRight, bool isLiftingToolUp,
        bool isPickingLeft, bool isPickingRight, bool isPickingUp, bool isPickingDown, bool isSwingingToolLeft, bool isSwingingToolRight,
        bool isSwingingToolUp, bool isSwingingToolDown, bool idleLeft, bool idleRight, bool idleUP, bool idleDown)
    {
        animator.SetFloat(Settings.xInput,xInput);
        animator.SetFloat(Settings.yInput, yInput);
        animator.SetBool(Settings.isWalking, isWalking);
        animator.SetBool(Settings.isRunning, isRunning);

        animator.SetInteger(Settings.toolEffect, (int)toolEffect);

        if (isUsingToolRight)
        {
            animator.SetTrigger(Settings.isUsingToolRight);
        }
        if (isUsingToolLeft)
        {
            animator.SetTrigger(Settings.isUsingToolLeft);
        }
        if (isUsingToolUp)
        {
            animator.SetTrigger(Settings.isUsingToolUp);
        }
        if (isUsingToolDown)
        {
            animator.SetTrigger(Settings.isUsingToolDown);
        }

        if (isLiftingToolRight)
        {
            animator.SetTrigger(Settings.isLiftingToolRight);
        }
        if (isLiftingToolLeft)
        {
            animator.SetTrigger(Settings.isLiftingToolLeft);
        }
        if (isLiftingToolUp)
        {
            animator.SetTrigger(Settings.isLiftingToolUp);
        }
        if (isLiftingToolDown)
        {
            animator.SetTrigger(Settings.isLiftingToolDown);
        }

        if (isSwingingToolRight)
        {
            animator.SetTrigger(Settings.isSwingingToolRight);
        }
        if (isSwingingToolLeft)
        {
            animator.SetTrigger(Settings.isSwingingToolLeft);
        }
        if (isSwingingToolUp)
        {
            animator.SetTrigger(Settings.isSwingingToolUp);
        }
        if (isSwingingToolDown)
        {
            animator.SetTrigger(Settings.isSwingingToolDown);
        }

        if (idleUP)
        {
            animator.SetTrigger(Settings.IdleUp);
        }
        if (idleRight)
        {
            animator.SetTrigger(Settings.IdleRight);
        }
        if (idleLeft)
        {
            animator.SetTrigger(Settings.IdleLeft);
        }
        if (idleDown)
        {
            animator.SetTrigger(Settings.IdleDown);
        }


    }

    private void AnimationEventPlayerfootstepSound()
    {

    }
}
