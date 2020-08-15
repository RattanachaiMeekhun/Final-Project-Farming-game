
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

    private Direction playerdirection;

    private float movementSpeed;

    private bool _playerInputIsDisable = false;
    public bool PlayerInputIsDisable { get => _playerInputIsDisable; set => _playerInputIsDisable = value; }

    protected void Awake()
    {
        base.Awake();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        #region Player Input

        ResetAnimationTriggers();

        PlayerMovementInput();

        PlayerWalckingInput();

        EventHandler.callMovementEvent(xInput, yInput, isWalking, isRunning, isCarrying, isIdle, toolEffect, isUsingToolLeft, isUsingToolDown, isUsingToolRight, isUsingToolUp,
               isLiftingToolDown, isLiftingToolLeft, isLiftingToolRight, isLiftingToolUp, isPickingLeft, isPickingRight, isPickingUp, isPickingDown,
               isSwingingToolLeft, isSwingingToolRight, isSwingingToolUp, isSwingingToolDown,
               false, false, false, false);

        #endregion

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

    private void PlayerWalckingInput()
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
                playerdirection = Direction.down;
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
}