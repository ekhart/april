using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public float startTime = 2.0f, 
				 repeatRate = 2.0f;

	public GameObject prefab;
	public Vector3 position;


	void Start () {
		InvokeRepeating("InstantiatePrefab", startTime, repeatRate);
	}
	
	void InstantiatePrefab () {
		Instantiate(prefab, position, Quaternion.identity);
	}
}
