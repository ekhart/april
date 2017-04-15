using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public float SpeedMaxX;
	public float SpeedMaxY;

	private float dx, dy;

	// Use this for initialization
	void Start () {
		dx = Random.Range(-SpeedMaxX, SpeedMaxX);
		dy = Random.Range(-SpeedMaxY, SpeedMaxY);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(dx, dy, 0);
	}
}
