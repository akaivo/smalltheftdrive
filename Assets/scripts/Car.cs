using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour {
	public GameObject shootingPointRight;
	public GameObject shootingPointLeft;
    public float bulletCooldown;
    public float bulletTimestamp;
	public float defaultX;
	public float limitRight;
	public float limitLeft;
	public float turnSpeed;
    // Use this for initialization
    void Start ()
    {
        bulletTimestamp = 0;
    }
	
	// Update is called once per frame
	void Update () {
		if (GameMain.chaseMode) {
			readChaseKeys ();
		} else {
			readShootKeys ();
		}
	}

	void readChaseKeys(){
		if (Input.GetMouseButton(0)) {
			Vector3 targetPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			float clickDistanceX = targetPoint.x - transform.position.x;
			transform.position += new Vector3(clickDistanceX * turnSpeed * Time.deltaTime,0f,0f);
			bulletTimestamp = Time.time;
		}
	}
	
	void readShootKeys(){
		if (Input.GetMouseButtonDown (0) && Time.time - bulletTimestamp > bulletCooldown) {
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
