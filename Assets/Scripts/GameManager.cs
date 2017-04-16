using UnityEngine;
using UnityEngine.UI;

public class GameManager {

	private static GameManager instance = new GameManager();

	public int Points;
	public Text ScoreText;
	

	private GameManager() { 
		ScoreText = GameObject.Find("ScoreText").GetComponent<Text>();
		
	}
	
	public static GameManager gm {
		get { return instance; }
	}

	public void AddPoints(int points) {
		Points += points;
		ScoreText.text = "Score: " + Points;
	}
}
