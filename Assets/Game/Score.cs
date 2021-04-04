using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

	public Text userName;
	public Text highScore;

	void Update()
	{
		userName.text = PlayerPrefs.GetString("UserName");
		highScore.text = WordManager.score.ToString();
	}
}
