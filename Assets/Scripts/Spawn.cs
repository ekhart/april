using UnityEngine;

public class Spawn : MonoBehaviour {

	public int SpawnMinTime = 1;
	public int SpawnMaxTime = 3;
	
	public GameObject[] prefabs;
    private float gatheredTime;
    private float nextSpawnTime;

    public Vector3 fromThrowForce = new Vector3(1, 1, 0);
    public Vector3 toThrowForce = new Vector3(11, 11, 0);

	private Vector3 ThrowForce {
        get {
            var x = Random.Range(fromThrowForce.x, toThrowForce.x);
            var y = Random.Range(fromThrowForce.y, toThrowForce.y);
            return new Vector3(x, y, 0);
        }
    }

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
        go.GetComponent<Rigidbody2D>().AddForce(ThrowForce, ForceMode2D.Impulse);
    }
}
