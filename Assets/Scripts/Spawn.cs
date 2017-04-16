using System.Collections;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public float repeatRate = 2.0f;
	
	public GameObject prefab;
    private float gatheredTime;
    private float nextSpawnTime;

    private 

	void Update() {
		gatheredTime += Time.deltaTime;
		
		if (gatheredTime > nextSpawnTime) {
			gatheredTime = 0;
			nextSpawnTime = Random.Range(1, 3);
			Instantiate(prefab, gameObject.transform.position, Quaternion.identity);
		}		
	}
}
