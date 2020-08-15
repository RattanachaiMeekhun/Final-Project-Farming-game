﻿
using UnityEngine;

public static class Settings
{

    public const float runningSpeed = 5.333f;
    public const float walkingSpeed = 2.666f;
    
    public static int xInput;
    public static int yInput;
    public static int isWalking;
    public static int isRunning;
    public static int toolEffect;
    public static int isCarrying;
    public static int isIdle;
    public static int isUsingToolLeft;
    public static int isUsingToolRight;
    public static int isUsingToolUp;
    public static int isUsingToolDown;
    public static int isLiftingToolLeft;
    public static int isLiftingToolRight;
    public static int isLiftingToolUp;
    public static int isLiftingToolDown;
    public static int isSwingingToolLeft;
    public static int isSwingingToolRight;
    public static int isSwingingToolUp;
    public static int isSwingingToolDown;
    public static int isPickingLeft;
    public static int isPickingRight;
    public static int isPickingUp;
    public static int isPickingDown;

    public static int IdleUp;
    public static int IdleDown;
    public static int IdleLeft;
    public static int IdleRight;

    static Settings()
    {
        xInput = Animator.StringToHash("xInput");
        yInput = Animator.StringToHash("yInput"); 
        isWalking = Animator.StringToHash("isWalking");
        isRunning = Animator.StringToHash("isRunning");
        toolEffect = Animator.StringToHash("toolEffect");
        isCarrying = Animator.StringToHash("isCarrying");
        isIdle = Animator.StringToHash("isIdle");
        isUsingToolDown = Animator.StringToHash("isUsingToolDown");
        isUsingToolLeft = Animator.StringToHash("isUsingToolLeft");
        isUsingToolRight = Animator.StringToHash("isUsingToolRight");
        isUsingToolUp = Animator.StringToHash("isUsingToolUp");
        isLiftingToolUp = Animator.StringToHash("isLiftingToolUp");
        isLiftingToolRight = Animator.StringToHash("isLiftingToolRight");
        isLiftingToolLeft = Animator.StringToHash("isLiftingToolLeft");
        isLiftingToolDown = Animator.StringToHash("isLiftingToolDown");
        isSwingingToolDown = Animator.StringToHash("isSwingingToolDown");
        isSwingingToolLeft = Animator.StringToHash("isSwingingToolLeft");
        isSwingingToolRight = Animator.StringToHash("isSwingingToolRight");
        isSwingingToolUp = Animator.StringToHash("isSwingingToolUp");
        isPickingDown = Animator.StringToHash("isPickingDown");
        isPickingLeft = Animator.StringToHash("isPickingLeft");
        isPickingRight = Animator.StringToHash("isPickingRight");
        isPickingUp = Animator.StringToHash("isPickingUp");

        IdleDown = Animator.StringToHash("IdleDown");
        IdleLeft = Animator.StringToHash("IdleLeft");
        IdleRight = Animator.StringToHash("IdleRight");
        IdleUp = Animator.StringToHash("IdleUp");
    }
}
