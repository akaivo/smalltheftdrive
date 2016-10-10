using UnityEngine;
using System.Collections;

public class Bunny : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.position = new Vector3(Random.Range(-5f,5f),10,0);
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position += Vector3.down * GameMain.speed * Time.deltaTime;
		if (transform.position.y < -10) {
			Destroy (gameObject);
		}
	}
}
