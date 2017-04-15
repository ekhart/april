using UnityEngine;

public class GameManager : MonoBehaviour {

	private static GameManager instance;

	public int Points;

	private GameManager() { }
	
	public static GameManager gm {
		get {
			if (instance == null) {
				instance = new GameManager();
			}
			return instance;
		}
	}

	public void AddPoints(int points) {
		Points += points;
	}

}
