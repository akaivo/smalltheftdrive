using UnityEngine;
using System.Collections;

public class BulletMaker : MonoBehaviour {
	public GameObject bulletPrefab;
	public float bulletSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			GameObject bulletGO = Instantiate (bulletPrefab);
			Bullet bullet = bulletGO.GetComponent<Bullet> ();
			bullet.transform.position = transform.position;
			Rigidbody2D rb = bullet.GetComponent<Rigidbody2D> ();
			Vector3 direction = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position).normalized;

			rb.velocity = direction * bullet.bulletSpeed;
		}
	}
}
