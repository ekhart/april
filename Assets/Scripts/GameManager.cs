using System;
using UnityEngine;
using UnityEngine.UI;

public class GameManager {
	private static GameManager instance = new GameManager();

    public int Points;
	public int Time = 30;

    internal void StartGame()
    {
        // currentState = 
    }

    public Text ScoreText;
	public Text TimeText;

	enum State
	{
		MAIN_MENU, PLAYING, GAME_OVER
	}
	
	State currentState;

	private GameManager() {
		currentState = State.MAIN_MENU;
		ScoreText = GameObject.Find("ScoreText").GetComponent<Text>();
		TimeText = GameObject.Find("TimeText").GetComponent<Text>();
	}

	public static GameManager gm {
		get { return instance; }
	}

	public void AddPoints(int points) {
		Points += points;
		ScoreText.text = "Score: " + Points;
	}

	public void SubtractSecond() {
		SubtractTime(1);
	}

	public void SubtractTime(int time) {
		Time -= time;
		
		if (Time <= 0) {
			GameObject.FindWithTag("GameController").GetComponent<GameManagerObject>().GameOver();
		}
		
		TimeText.text = "Time: " + Time + "s";
	}

	public void SetPoints(Points points)
    {
        if (points.Value != 0) {
			AddPoints(points.Value);
		}

		if (points.Time != 0) {
			SubtractTime(points.Time);
		}
    }

}
