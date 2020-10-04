using TMPro;
using UnityEngine;


public class GameClock : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timeText ;
    [SerializeField] private TextMeshProUGUI dateText ;
    [SerializeField] private TextMeshProUGUI seasonText ;
    [SerializeField] private TextMeshProUGUI yearText ;

    private void Start()
    {
        timeText = null;
        dateText = null;
        seasonText = null;
        yearText = null;
    }

    private void OnEnable()
    {
        EventHandler.AdvanceGameMinuteEvent += UpdateGametime;
    }
    private void OnDisable()
    {
        EventHandler.AdvanceGameMinuteEvent -= UpdateGametime;
    }

    private void UpdateGametime(int gameYear, Season gameSeason, int gameDay, string gameDayofWeek, int gameHour, int gameMinute
        , int gameSecond)
    {
        gameMinute = gameMinute - (gameMinute % 10);

        string ampm = "";
        string mintue;

        if (gameHour >= 12)
        {
            ampm = "pm";
        }
        else
        {
            ampm = "am";
        }

        if (gameHour>=13)
        {
            gameHour -= 12;
        }

        if (gameMinute < 10)
        {
            mintue = "0" + gameMinute.ToString();
        }
        else
        {
            mintue = gameMinute.ToString();
        }

        string time = gameHour.ToString() + " : " + mintue + ampm;
    
 
    
    }
}
