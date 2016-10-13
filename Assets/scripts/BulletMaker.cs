using UnityEngine;
using System.Collections;

public class BulletMaker : MonoBehaviour {
	public GameObject bulletPrefab;
	public bool right;
	public float bulletSpeed;
	public AudioClip shot;
	// Use this for initialization

	void Shoot(){
		Vector3 targetPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		GameObject bulletGO = Instantiate (bulletPrefab);
		Bullet bullet = bulletGO.GetComponent<Bullet> ();
		bullet.transform.position = transform.position;
		Rigidbody2D rb = bullet.GetComponent<Rigidbody2D> ();
		Vector3 direction = (targetPoint- transform.position);
		direction.z = 0;
		direction.Normalize ();
		rb.velocity = direction.normalized * bullet.bulletSpeed;

		AudioSource audioSource = gameObject.AddComponent<AudioSource> ();
		audioSource.clip = shot;
		audioSource.playOnAwake = false;

		audioSource.Play();
	}
	void Update(){
		AudioSource[] audioSources = gameObject.GetComponents<AudioSource> ();
		foreach (AudioSource audioSource in audioSources) {
			if (!audioSource.isPlaying) {
				Destroy (audioSource);
			}
		}
	}
}
