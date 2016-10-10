using UnityEngine;
using System.Collections;

public class BulletMaker : MonoBehaviour {
	public GameObject bulletPrefab;
	public bool right;
	public float bulletSpeed;
    private AudioSource shot;
	// Use this for initialization
	void Start () {
        shot = this.GetComponent<AudioSource>();
	}
	

	void Shoot(){
		Vector3 targetPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		GameObject bulletGO = Instantiate (bulletPrefab);
		Bullet bullet = bulletGO.GetComponent<Bullet> ();
		bullet.transform.position = transform.position;
		Rigidbody2D rb = bullet.GetComponent<Rigidbody2D> ();
		Vector3 direction = (targetPoint- transform.position);
		direction.z = 0;
		direction.Normalize ();
		shot.Play();
		rb.velocity = direction.normalized * bullet.bulletSpeed;

	}
}
