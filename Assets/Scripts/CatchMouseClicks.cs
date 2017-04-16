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

// UnityException: Gizmo drawing functions can only be used in OnDrawGizmos and OnDrawGizmosSelected.
// UnityEngine.Gizmos.DrawLine (Vector3 from, Vector3 to) (at C:/buildslave/unity/build/artifacts/generated/common/runtime/GizmoBindings.gen.cs:30)
// CatchMouseClicks.OnMouseUp () (at Assets/Scripts/CatchMouseClicks.cs:24)
// UnityEngine.SendMouseEvents:DoSendMouseEvents(Int32)
		// Gizmos.color = Color.black;
        // Gizmos.DrawLine (startPosition, endPosition);

		var line = GetComponent<LineRenderer>();
		var start = ScreenToWorldPoint(this.startPosition);
		var end = ScreenToWorldPoint(this.endPosition);
		line.numPositions = 2;
		line.SetPositions(new[] { start, end });
	}

	Vector3 ScreenToWorldPoint(Vector3 vector) {
		var v = Camera.main.ScreenToWorldPoint(vector);
		v.z = 0;
		return v;
	}
}
