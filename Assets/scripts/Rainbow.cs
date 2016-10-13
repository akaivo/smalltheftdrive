using UnityEngine;
using System.Collections;

public class Rainbow : MonoBehaviour {
	public GameObject starPrefab;
	// Use this for initialization
	void Start () {
		makeStars (Random.Range (3, 5));
	}

	void makeStars(int stars){
		for (int i = 0; i < stars; i++) {
			int angle = Random.Range (0, 360);
			Vector3 direction = Quaternion.AngleAxis (angle, Vector3.forward) * Vector3.right;
			direction.z = 0;
			direction.Normalize ();

			GameObject star = Instantiate (starPrefab);
			star.transform.parent = gameObject.transform;
			star.transform.position = gameObject.transform.position;
			Rigidbody2D rb = star.GetComponent<Rigidbody2D> ();
			rb.velocity = direction * Random.Range (0.3f, 4f);
		}
	}
	
}
