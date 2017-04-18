using UnityEngine;

public class DestroyOnMouseDown : MonoBehaviour {
	void OnMouseDown()
    {
        GameManager.gm.SetPoints(GetComponent<Points>());
		
		Destroy(gameObject);
    }
}
