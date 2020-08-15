using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationTest : MonoBehaviour
{
    public float xInput;
    public float yInput;
    public bool isWalking;
    public bool isRunning;
    public ToolEffect toolEffect;
    public bool isCarrying;
    public bool isIdle;
    public bool isUsingToolLeft;
    public bool isUsingToolRight;
    public bool isUsingToolUp;
    public bool isUsingToolDown;
    public bool isLiftingToolDown;
    public bool isLiftingToolLeft;
    public bool isLiftingToolRight;
    public bool isLiftingToolUp;
    public bool isSwingingToolLeft;
    public bool isSwingingToolRight;
    public bool isSwingingToolUp;
    public bool isSwingingToolDown;
    public bool isPickingLeft;
    public bool isPickingRight;
    public bool isPickingUp;
    public bool isPickingDown;

    public bool IdleUp;
    public bool IdleDown;
    public bool IdleLeft;
    public bool IdleRight;

    private void Update()
    {
        EventHandler.callMovementEvent(xInput, yInput, isWalking, isRunning, isCarrying, isIdle, toolEffect, isUsingToolLeft, isUsingToolDown, isUsingToolRight, isUsingToolUp,
                isLiftingToolDown, isLiftingToolLeft, isLiftingToolRight, isLiftingToolUp, isPickingLeft, isPickingRight, isPickingUp, isPickingDown,
                isSwingingToolLeft, isSwingingToolRight, isSwingingToolUp, isSwingingToolDown,
                IdleLeft, IdleRight, IdleUp, IdleDown);
    }
}
