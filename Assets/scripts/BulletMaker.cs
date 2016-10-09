using UnityEngine;
using System.Collections;

public class BulletMaker : MonoBehaviour {
	public GameObject bulletPrefab;
	public float bulletSpeed;
    private AudioSource shot;
	// Use this for initialization
	void Start () {
        shot = this.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			GameObject bulletGO = Instantiate (bulletPrefab);
			Bullet bullet = bulletGO.GetComponent<Bullet> ();
			bullet.transform.position = transform.position;
			Rigidbody2D rb = bullet.GetComponent<Rigidbody2D> ();
			Vector3 direction = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position).normalized;
            shot.Play();
			rb.velocity = direction * bullet.bulletSpeed;
		}
	}
}
