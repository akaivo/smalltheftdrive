using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour {
	public GameObject shootingPointRight;
	public GameObject shootingPointLeft;
    public float bulletCooldown;
    public float bulletTimestamp;
    // Use this for initialization
    void Start ()
    {
        bulletCooldown = 2;
        bulletTimestamp = 0;
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) && Time.time - bulletTimestamp>bulletCooldown) {
			Vector3 targetPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			if (targetPoint.x > transform.position.x) {
				shootingPointRight.SendMessage ("Shoot");
			} else {
				shootingPointLeft.SendMessage ("Shoot");
			}
		    bulletTimestamp = Time.time;
		}
	}
}
