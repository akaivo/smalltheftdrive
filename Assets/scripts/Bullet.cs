using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public float bulletSpeed;

	void Update(){
		if (transform.position.magnitude > 16) {
			Destroy (gameObject);
		}
	}
    void OnCollisionEnter()
    {
        Destroy(gameObject);
    }
}


