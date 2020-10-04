
using System;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class UIManager : SingletonMonobehaviour<UIManager>
{
    private bool _pauseMenuOn = false;
    [SerializeField] private GameObject pauseMenu = null;
    [SerializeField] private GameObject[] menuTabs = null;
    [SerializeField] private Button[] menuButtons = null;

    public bool PauseMenuOn { get => _pauseMenuOn; set => _pauseMenuOn = value; }

    protected override void Awake()
    {
        base.Awake();

        pauseMenu.SetActive(false);
    }

    private void Update()
    {
        PauseMenu();
    }

    private void PauseMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseMenuOn)
            {
                DisablePauseMenu();
            }
            else
            {
                EnablePauseMenu();
            }
        }
    }

    private void EnablePauseMenu()
    {
        PauseMenuOn = true;
        Player.Instance.PlayerInputIsDisable = true;
        Time.timeScale = 0;
        pauseMenu.SetActive(true);

        System.GC.Collect();

        HighlightButtonForSelectedTab();

    }

    private void HighlightButtonForSelectedTab()
    {
        for (int i = 1;i < menuTabs.Length; i++)
        {
            if (menuTabs[i].activeSelf)
            {
                setButtonColorToActive(menuButtons[i]);
            }
            else
            {
                setButtonColorToInActive(menuButtons[i]);
            }
        }
    }

    private void setButtonColorToInActive(Button button)
    {
        ColorBlock color = button.colors;
        color.normalColor = color.disabledColor;
        button.colors = color;
    }

    private void setButtonColorToActive(Button button)
    {
        ColorBlock color = button.colors;
        color.normalColor = color.pressedColor;
        button.colors = color;
    }

    private void DisablePauseMenu()
    {
        PauseMenuOn = false;
        Player.Instance.PlayerInputIsDisable = false;
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }

    public void SwitchPauseMenuTab(int tabNum)
    {
        for (int i = 0; i < menuTabs.Length; i++)
        {
            if (i != tabNum)
            {
                menuTabs[i].SetActive(false);
            }
            else
            {
                menuTabs[i].SetActive(true);
            }
        }
        HighlightButtonForSelectedTab();
    }
}
