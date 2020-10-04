
using UnityEngine;

public class ButtonLevel : SingletonMonobehaviour<ButtonLevel>
{
    public GameObject buttonLevel;
    public GameObject skill1;
    public GameObject skill2;
    public GameObject levelCanvas;
    public GameObject Mainmenu;
    public void LevelUpEvent()
    {
        Mainmenu.SetActive(false);
        levelCanvas.SetActive(true);
        buttonLevel.SetActive(false);
       
    }

    public void LevelSelection1()
    {
        Mainmenu.SetActive(true);
        levelCanvas.SetActive(false);
    }
    public void LevelSelection2()
    {
        Mainmenu.SetActive(true);
        levelCanvas.SetActive(false);
    }

}
