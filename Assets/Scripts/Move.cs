using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public float SpeedMinX;
	public float SpeedMaxX;
	
	public float SpeedMinY;
	public float SpeedMaxY;

	private Vector3 position;

	// Use this for initialization
	void Start () {
		var x = Random.Range(SpeedMinX, SpeedMaxX);
		var y = Random.Range(SpeedMinY, SpeedMaxY);
		position = new Vector3(x, y, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
		// transform.position += position;
	}
}
