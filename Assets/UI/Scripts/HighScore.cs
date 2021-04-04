using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HighScore : MonoBehaviour
{
    public Text highScore;

    void Update()
    {
        highScore.text = PlayerPrefs.GetString("UserName") + " - " + PlayerPrefs.GetInt("Highscore").ToString();
        if (!Input.GetKey("d"))
        {
            if (Input.anyKey)
            {
                SceneManager.LoadScene("Game");
            }
        }


        if (Input.GetKey("d"))
        {
            PlayerPrefs.DeleteKey("Highscore");
            //PlayerPrefs.DeleteKey("UserName");
        }

    }
}
