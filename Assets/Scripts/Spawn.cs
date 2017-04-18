using UnityEngine;

public class Spawn : MonoBehaviour {

	public int SpawnMinTime = 1;
	public int SpawnMaxTime = 3;
	
	public GameObject[] prefabs;
    private float gatheredTime;
    private float nextSpawnTime;

    public Vector3 throwForce = new Vector3(9, 9, 0);

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
        var go = Instantiate(prefabs[i], gameObject.transform.position, Quaternion.identity);
        go.transform.parent = this.transform;
        go.GetComponent<Rigidbody2D>().AddForce(throwForce, ForceMode2D.Impulse);
    }
}
