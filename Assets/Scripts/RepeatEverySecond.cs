using UnityEngine;

public class RepeatEverySecond : MonoBehaviour {

	void Start () {
		InvokeRepeating("SubtractSecond", 1, 1);	
	}

	void SubtractSecond() {
		GameManager.gm.SubtractSecond();
	}
	
}
