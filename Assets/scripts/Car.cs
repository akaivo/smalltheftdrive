using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour {
	public GameObject shootingPointRight;
	public GameObject shootingPointLeft;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Vector3 targetPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			if (targetPoint.x > transform.position.x) {
				shootingPointRight.SendMessage ("Shoot");
			} else {
				shootingPointLeft.SendMessage ("Shoot");
			}
		}
	}
}
