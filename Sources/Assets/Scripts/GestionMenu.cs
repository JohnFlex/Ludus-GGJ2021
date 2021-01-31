using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionMenu : MonoBehaviour
{

    public void PlayGame()
    {
      
        SceneManager.LoadScene("Level2");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void PlaySetting()
    {
        SceneManager.LoadScene("OptionScene");
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
