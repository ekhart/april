using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfter : MonoBehaviour {

	public float timeToDestroy = 2.0f;

	void Start () {
		Invoke("DestroyMe", timeToDestroy);		
	}

	void DestroyMe () {
		Destroy(gameObject);	
	}
}
