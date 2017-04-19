using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerObject : MonoBehaviour {

	public Button StartButton, RestartButton;

	void Start () {
		Time.timeScale = 0;
		StartButton.gameObject.SetActive(true);
		RestartButton.gameObject.SetActive(false);
	}
	
	public void StartGame() {
		Time.timeScale = 1;
		StartButton.gameObject.SetActive(false);
		RestartButton.gameObject.SetActive(false);
	}

	public void RestartGame() {
		SceneManager.LoadScene("main");
		GameManager.gm.RestartGame();
	}

	public void GameOver() {
		Time.timeScale = 0;
		StartButton.gameObject.SetActive(false);
		RestartButton.gameObject.SetActive(true);
	}
}
