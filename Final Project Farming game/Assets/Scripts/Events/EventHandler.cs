using System;
using System.Collections.Generic;


public delegate void MovementDelegate(float xInput, float yInput, bool isWalking, bool isRunning, bool isIdle,
    bool isCarrying, ToolEffect toolEffect,
    bool isUsingToolLeft, bool isUsingToolRight, bool isUsingToolDown, bool isUsingToolUp,
    bool isLiftingToolLeft, bool isLiftingToolRight, bool isLiftingToolUp, bool isLiftingToolDown,
    bool isPickingLeft, bool isPickingRight, bool isPickingUp, bool isPickingDown,
    bool isSwingingToolLeft, bool isSwingingToolRight, bool isSwingingToolUp, bool isSwingingToolDown,
    bool IdleLeft, bool IdleRight, bool IdleUP, bool IdleDown);

public static class EventHandler {

    public static event Action<InventoryLocation, List<InventoryItem>> InventoryUpdatedEvent;

    public static void CallInventoryUpdatedEvent(InventoryLocation inventoryLocation, List<InventoryItem> inventoryList)
    {
        if (InventoryUpdatedEvent != null)
        {
            InventoryUpdatedEvent(inventoryLocation, inventoryList);
        }
    }

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
            MovementEvent(xInput, yInput, isWalking, isRunning, isCarrying, isIdle, toolEffect, isUsingToolLeft, isUsingToolDown, isUsingToolRight, isUsingToolUp,
                isLiftingToolDown, isLiftingToolLeft, isLiftingToolRight, isLiftingToolUp, isPickingLeft, isPickingRight, isPickingUp, isPickingDown,
                isSwingingToolLeft, isSwingingToolRight, isSwingingToolUp, isSwingingToolDown,
                IdleLeft, IdleRight, IdleUP, IdleDown);
        }
    }

    public static event Action<int, Season, int, string, int, int, int> AdvanceGameMinuteEvent;

    public static void CallAdvanceGameMinuteEvent(int gameYear,Season gameSeason,int gameDay,string gameDayofWeek,int gameHour,int gameMinute
        ,int gameSecond)
    {
        if (AdvanceGameMinuteEvent != null)
        {
            AdvanceGameMinuteEvent(gameYear, gameSeason, gameDay, gameDayofWeek, gameHour, gameMinute, gameSecond);
        }
    }

    public static event Action<int, Season, int, string, int, int, int> AdvanceGameHourEvent;

    public static void CallAdvanceGameHourEvent(int gameYear, Season gameSeason, int gameDay, string gameDayofWeek, int gameHour, int gameMinute
        , int gameSecond)
    {
        if (AdvanceGameHourEvent != null)
        {
            AdvanceGameHourEvent(gameYear, gameSeason, gameDay, gameDayofWeek, gameHour, gameMinute, gameSecond);
        }
    }

    public static event Action<int, Season, int, string, int, int, int> AdvanceGameDayEvent;

    public static void CallAdvanceGameDayEvent(int gameYear, Season gameSeason, int gameDay, string gameDayofWeek, int gameHour, int gameMinute
        , int gameSecond)
    {
        if (AdvanceGameDayEvent != null)
        {
            AdvanceGameDayEvent(gameYear, gameSeason, gameDay, gameDayofWeek, gameHour, gameMinute, gameSecond);
        }
    }

    public static event Action<int, Season, int, string, int, int, int> AdvanceGameSeasonEvent;

    public static void CallAdvanceGameSeasonEvent(int gameYear, Season gameSeason, int gameDay, string gameDayofWeek, int gameHour, int gameMinute
        , int gameSecond)
    {
        if (AdvanceGameSeasonEvent != null)
        {
            AdvanceGameSeasonEvent(gameYear, gameSeason, gameDay, gameDayofWeek, gameHour, gameMinute, gameSecond);
        }
    }

    public static event Action<int, Season, int, string, int, int, int> AdvanceGameYearEvent;

    public static void CallAdvanceGameYearEvent(int gameYear, Season gameSeason, int gameDay, string gameDayofWeek, int gameHour, int gameMinute
        , int gameSecond)
    {
        if (AdvanceGameYearEvent != null)
        {
            AdvanceGameYearEvent(gameYear, gameSeason, gameDay, gameDayofWeek, gameHour, gameMinute, gameSecond);
        }
    }

    public static event Action BeforeSceneUnloadFadeOutEvent;

    public static void CallBeforeSceneUnloadFadeOutEvent()
    {
        if (BeforeSceneUnloadFadeOutEvent != null)
        {
            BeforeSceneUnloadFadeOutEvent();
        }
    }

    public static event Action BeforeSceneUnloadEvent;

    public static void CallBeforeSceneUnloadEvent()
    {
        if (BeforeSceneUnloadEvent != null)
        {
            BeforeSceneUnloadEvent();
        }
    }

    public static event Action AfterSceneLoadEvent;

    public static void CallAfterSceneLoadEvent()
    {
        if (AfterSceneLoadEvent != null)
        {
            AfterSceneLoadEvent();
        }
    }

    public static event Action AfterSceneLoadFadeInEvent;

    public static void CallAfterSceneLoadFadeInEvent()
    {
        if (AfterSceneLoadFadeInEvent != null)
        {
            AfterSceneLoadFadeInEvent();
        }
    }

}