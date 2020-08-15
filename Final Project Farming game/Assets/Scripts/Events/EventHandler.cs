public delegate void MovementDelegate(float xInput, float yInput, bool isWalking, bool isRunning, bool isIdle,
    bool isCarrying, ToolEffect toolEffect,
    bool isUsingToolLeft, bool isUsingToolRight, bool isUsingToolDown, bool isUsingToolUp,
    bool isLiftingToolLeft, bool isLiftingToolRight, bool isLiftingToolUp, bool isLiftingToolDown,
    bool isPickingLeft, bool isPickingRight, bool isPickingUp, bool isPickingDown,
    bool isSwingingToolLeft, bool isSwingingToolRight, bool isSwingingToolUp, bool isSwingingToolDown,
    bool IdleLeft, bool IdleRight, bool IdleUP, bool IdleDown);

public static class EventHandler{
    //MovementEvent
    public static event MovementDelegate MovementEvent;

    //MovementEvent call for publisher
    public static void callMovementEvent(float xInput, float yInput, bool isWalking, bool isRunning, bool isIdle, 
    bool isCarrying, ToolEffect toolEffect, 
    bool isUsingToolLeft, bool isUsingToolRight, bool isUsingToolDown, bool isUsingToolUp,
    bool isLiftingToolDown, bool isLiftingToolLeft, bool isLiftingToolRight, bool isLiftingToolUp, 
    bool isPickingLeft, bool isPickingRight, bool isPickingUp, bool isPickingDown,
    bool isSwingingToolLeft, bool isSwingingToolRight, bool isSwingingToolUp, bool isSwingingToolDown,
    bool IdleLeft, bool IdleRight, bool IdleUP, bool IdleDown)
    {
        if (MovementEvent != null)
        {
            MovementEvent(xInput, yInput, isWalking,isRunning,isCarrying,isIdle,toolEffect, isUsingToolLeft, isUsingToolDown, isUsingToolRight, isUsingToolUp,
                isLiftingToolDown ,isLiftingToolLeft, isLiftingToolRight, isLiftingToolUp , isPickingLeft,  isPickingRight,  isPickingUp,  isPickingDown,
                isSwingingToolLeft,  isSwingingToolRight,  isSwingingToolUp,  isSwingingToolDown,
                IdleLeft, IdleRight, IdleUP, IdleDown);
        }
    }

}