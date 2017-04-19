using System;
using UnityEngine;
using UnityEngine.UI;

public class GameManager {
	private static GameManager instance = new GameManager();

    public int Points;
	public int Time = 30;

	private Text scoreText;
    public Text ScoreText {
		get {
			if (!scoreText) {
				scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
			}
			return scoreText;
		}
	}
	public Text timeText;
	public Text TimeText {
		get {
			if (!timeText) {
				timeText = GameObject.Find("TimeText").GetComponent<Text>();
			}
			return timeText;
		}
	}

    enum State
	{
		MAIN_MENU, PLAYING, GAME_OVER
	}
	
	State currentState;

	private GameManager() {
		currentState = State.MAIN_MENU;
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

	internal void RestartGame()
    {
        AddPoints(-Points);
		SubtractTime(-Time - 30);
    }
}
