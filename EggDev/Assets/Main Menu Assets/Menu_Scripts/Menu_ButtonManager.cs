using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_ButtonManager : MonoBehaviour {

	public void EnterLoadMenu(string loadMenu)
    {
        SceneManager.LoadScene(loadMenu);

    }

    public void EnterSettingMenu(string optionMenu)
    {
        SceneManager.LoadScene(optionMenu);
    }

    public void EnterAboutMenu(string aboutMenu)
    {
        SceneManager.LoadScene(aboutMenu);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
