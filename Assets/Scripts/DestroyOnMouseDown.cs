using UnityEngine;

public class DestroyOnMouseDown : MonoBehaviour {
	void OnMouseDown()
    {
        int value = GetComponent<Points>().Value;
        GameManager.gm.AddPoints(value);
		
		Destroy(gameObject);
    }
}
