using UnityEngine;

public class Spawn : MonoBehaviour {

	public int SpawnMinTime = 1;
	public int SpawnMaxTime = 3;
	
	public GameObject[] prefabs;
    private float gatheredTime;
    private float nextSpawnTime;

    private 

	void Update() {
		gatheredTime += Time.deltaTime;

		if (gatheredTime > nextSpawnTime)
        {
			gatheredTime = 0;
        	nextSpawnTime = Random.Range(SpawnMinTime, SpawnMaxTime);
			SpawnPrefab();
        }
    }

    private void SpawnPrefab()
    {
        var i = Random.Range(0, prefabs.Length);
        Instantiate(prefabs[i], gameObject.transform.position, Quaternion.identity);
    }
}
