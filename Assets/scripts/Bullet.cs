using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public float bulletSpeed;

	void Update(){
		if (transform.position.magnitude > 16) {
			Destroy (gameObject);
		}
	}
	void OnTriggerEnter2D(Collider2D coll) {
		Destroy (coll.gameObject);
		Destroy (gameObject);
	}
}


