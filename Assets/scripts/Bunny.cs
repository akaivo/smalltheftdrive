using UnityEngine;
using System.Collections;

public class Bunny : MonoBehaviour {
	public GameObject rainbowPrefab;
	public int points;
	// Use this for initialization
	void Start ()
	{
	    int rand = Random.Range(-1, 1);
	    float xPos = Random.Range(1.95f, 3.5f);
	    xPos = rand >= 0 ? xPos : (xPos*-1);
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
		ScoreKeeper.score += points;
		GameObject rainbow = Instantiate (rainbowPrefab);
		rainbow.transform.position = transform.position;
	}
		
}
