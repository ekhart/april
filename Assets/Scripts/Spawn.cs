using System.Collections;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public float repeatRate = 2.0f;

	public GameObject prefab;
	public Vector3 position;


	void FixedUpdate () {
		StartCoroutine(InstantiatePrefab);
	}
	
	private IEnumerator InstantiatePrefab {
		get {
			Instantiate(prefab, position, Quaternion.identity);

			var seconds = Random.Range(1, 3);
			yield return new WaitForSeconds(seconds);
		}
	}
}
