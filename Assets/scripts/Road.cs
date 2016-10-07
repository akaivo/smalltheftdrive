using UnityEngine;
using System.Collections;

public class Road : MonoBehaviour {
	// Update is called once per frame
	void Update () {
		gameObject.transform.position += Vector3.down * GameMain.speed * Time.deltaTime;
		if (gameObject.transform.position.y < -10) {
			gameObject.transform.position += Vector3.up * 20;
		}
	}
}
