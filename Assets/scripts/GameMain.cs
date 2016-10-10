using UnityEngine;
using System.Collections;

public class GameMain : MonoBehaviour {
	public static float speed;
	public float setSpeed;
	public GameObject bunnyPrefab;
	public float bunninity;

	// Use this for initialization
	void Start () {
		speed = setSpeed;
	}

	void Update(){
		float number = Random.value;
		float chanceOfBunny = Time.deltaTime* bunninity;
		if (chanceOfBunny > number) {
			GameObject bunnyGo = Instantiate (bunnyPrefab);
		}
	}
}
