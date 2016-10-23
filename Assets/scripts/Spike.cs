using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Spike : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float xPos = Random.Range(-1f, 1f);
		transform.position = new Vector3(xPos,10,0);
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position += Vector3.down * GameMain.speed * Time.deltaTime;
		if (transform.position.y < -10) {
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.tag == "car") {
			Destroy (coll.gameObject);
		}
		SceneManager.LoadScene("scenes/gameover");
	}
}
