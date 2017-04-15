public class GameManager {

	private static GameManager instance = new GameManager();

	public int Points;

	private GameManager() { }
	
	public static GameManager gm {
		get { return instance; }
	}

	public void AddPoints(int points) {
		Points += points;
	}
}
