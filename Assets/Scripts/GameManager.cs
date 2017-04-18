using UnityEngine;
using UnityEngine.UI;

public class GameManager {

	private static GameManager instance = new GameManager();
	public int Points;
	public int Time = 30;
	public Text ScoreText;
	public Text TimeText;

	private GameManager() { 
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
		Time--;
		TimeText.text = "Time: " + Time + "s";
	}
}
