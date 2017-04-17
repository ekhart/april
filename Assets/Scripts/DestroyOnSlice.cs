using UnityEngine;

public class DestroyOnSlice : MonoBehaviour {

	void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == "Line")
        {
            // Camera.main.GetComponent<AudioSource>().Play();
            // Destroy(gameObject);
            // Instantiate(splashReference, randomPos, transform.rotation);
 
            int value = GetComponent<Points>().Value;
			GameManager.gm.AddPoints(value);
			
			Destroy(gameObject);
        }
    }
}
