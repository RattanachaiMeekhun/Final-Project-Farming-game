
using System;
using UnityEngine;

public class Player : SingletonMonobehaviour<Player>
{
    private float xInput;
    private float yInput;
    private bool isWalking;
    private bool isRunning;
    private ToolEffect toolEffect = ToolEffect.none;
    private bool isCarrying;
    private bool isIdle;
    private bool isUsingToolLeft;
    private bool isUsingToolRight;
    private bool isUsingToolUp;
    private bool isUsingToolDown;
    private bool isLiftingToolDown;
    private bool isLiftingToolLeft;
    private bool isLiftingToolRight;
    private bool isLiftingToolUp;
    private bool isSwingingToolLeft;
    private bool isSwingingToolRight;
    private bool isSwingingToolUp;
    private bool isSwingingToolDown;
    private bool isPickingLeft;
    private bool isPickingRight;
    private bool isPickingUp;
    private bool isPickingDown;

    private Rigidbody2D rigidbody2D;
#pragma warning disable 414  
    private Direction playerdirection;
#pragma warning restore 414
    private float movementSpeed;

    private Camera mainCamera;

    private bool _playerInputIsDisable = false;
    public bool PlayerInputIsDisable { get => _playerInputIsDisable; set => _playerInputIsDisable = value; }

    protected void Awake()
    {
        base.Awake();
        rigidbody2D = GetComponent<Rigidbody2D>();

        mainCamera = Camera.main;
    }
    private void Update()
    {
        #region Player Input

        if (!PlayerInputIsDisable)
        {
            ResetAnimationTriggers();

            PlayerMovementInput();

            PlayerWalkingInput();

            PlayerTestInput();

            EventHandler.callMovementEvent(xInput, yInput, isWalking, isRunning, isCarrying, isIdle, toolEffect, isUsingToolLeft, isUsingToolDown, isUsingToolRight, isUsingToolUp,
                           isLiftingToolDown, isLiftingToolLeft, isLiftingToolRight, isLiftingToolUp, isPickingLeft, isPickingRight, isPickingUp, isPickingDown,
                           isSwingingToolLeft, isSwingingToolRight, isSwingingToolUp, isSwingingToolDown,
                           false, false, false, false);
        }

        

        #endregion Player Input


    }

    private void FixedUpdate()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        Vector2 move = new Vector2(xInput * movementSpeed * Time.deltaTime,yInput * movementSpeed * Time.deltaTime);

        rigidbody2D.MovePosition(rigidbody2D.position + move);
    }

    private void PlayerWalkingInput()
    {
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            isRunning = false;
            isWalking = true;
            isIdle = false;
            movementSpeed = Settings.walkingSpeed;
        }
        else
        {
            isRunning = true;
            isWalking = false;
            isIdle = false;
            movementSpeed = Settings.runningSpeed;
        }
    }

    private void PlayerMovementInput()
    {
        yInput = Input.GetAxisRaw("Vertical");
        xInput = Input.GetAxisRaw("Horizontal");

        if (yInput != 0 && xInput != 0)
        {
            xInput = xInput * 0.71f;
            yInput = yInput * 0.71f;
        }

        if (xInput != 0 || yInput != 0)
        {
            isRunning = true;
            isWalking = false;
            isIdle = false;
            movementSpeed = Settings.runningSpeed;

            if (xInput < 0)
            {
                playerdirection = Direction.left;
            }else if (xInput > 0)
            {
                playerdirection = Direction.right;
            }
            else if (yInput < 0)
            {
                playerdirection = Direction.down;
            }
            else
            {
                playerdirection = Direction.up;
            }

        }else if (xInput == 0 && yInput ==0)
        {
            isRunning = false;
            isWalking = false;
            isIdle = true;
        }
    }

    private void ResetAnimationTriggers()
    {
        isPickingDown = false;
        isPickingRight = false;
        isPickingLeft= false;
        isPickingUp = false;
        isUsingToolLeft = false;
        isUsingToolRight = false;
        isUsingToolDown = false;
        isUsingToolUp = false;
        isSwingingToolLeft = false;
        isSwingingToolRight = false;
        isSwingingToolDown = false;
        isSwingingToolUp = false;
        isLiftingToolRight = false;
        isLiftingToolLeft= false;
        isLiftingToolUp = false;
        isLiftingToolDown = false;


    }

    public void PlayerTestInput()
    {
        if (Input.GetKey(KeyCode.T))
        {
            TimeManager.Instance.TestAdvanceGameMinute();
        }
        if (Input.GetKey(KeyCode.K))
        {
            TimeManager.Instance.TestAdvanceGameDay();
        }
    }

    public void DisablePlayerInputAndResetMovement()
    {
        DisablePlayerInput();
        ResetMovement();

        EventHandler.callMovementEvent(xInput, yInput, isWalking, isRunning, isCarrying, isIdle, toolEffect, isUsingToolLeft, isUsingToolDown, isUsingToolRight, isUsingToolUp,
                           isLiftingToolDown, isLiftingToolLeft, isLiftingToolRight, isLiftingToolUp, isPickingLeft, isPickingRight, isPickingUp, isPickingDown,
                           isSwingingToolLeft, isSwingingToolRight, isSwingingToolUp, isSwingingToolDown,
                           false, false, false, false);

    }

    private void ResetMovement()
    {
        xInput = 0f;
        yInput = 0f;
        isRunning = false;
        isWalking = false;
        isIdle = true;
    }

    public void DisablePlayerInput()
    {
        PlayerInputIsDisable = true;
    }

    public void EnablePlayerInput()
    {
        PlayerInputIsDisable = false;
    }

    public Vector3 GetPlayerViewportPosition()
    {
        return mainCamera.WorldToViewportPoint(transform.position);
    }

}