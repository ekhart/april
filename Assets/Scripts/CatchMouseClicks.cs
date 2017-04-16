using UnityEngine;

public class CatchMouseClicks : MonoBehaviour {

	public Vector3 startPosition, endPosition;

	/// <summary>
	/// OnMouseDown is called when the user has pressed the mouse button while
	/// over the GUIElement or Collider.
	/// </summary>
	void OnMouseDown()
	{
		startPosition = Input.mousePosition;
	}

	/// <summary>
	/// OnMouseUp is called when the user has released the mouse button.
	/// </summary>
	void OnMouseUp()
	{
		endPosition = Input.mousePosition;
	}

}
