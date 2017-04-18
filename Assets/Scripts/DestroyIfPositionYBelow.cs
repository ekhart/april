using UnityEngine;

public class DestroyIfPositionYBelow : MonoBehaviour {

	public int y = -20;
	
	void Update() {
        if (gameObject.transform.position.y < y) {
            Destroy(gameObject);
        }
    }
}
