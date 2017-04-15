using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public float startTime = 2.0f, 
				 repeatRate = 2.0f;

	public GameObject go;
	public Vector3 position;


	void Start () {
		InvokeRepeating("InstantiatePrefab", startTime, repeatRate);
	}
	
	void InstantiatePrefab () {
		Instantiate(go, position, Quaternion.identity);
	}
}
