using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void OpenURL()
    {
        Application.OpenURL("https://github.com/ThisIsMeWinning/falling-words");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("QUIT");
    }

}
