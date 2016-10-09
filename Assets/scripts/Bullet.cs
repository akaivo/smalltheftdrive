using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public float bulletSpeed;


    void OnCollisionEnter()
    {
        Destroy(gameObject);
    }
}


