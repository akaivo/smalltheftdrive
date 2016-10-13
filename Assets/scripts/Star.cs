using UnityEngine;
using System.Collections;

public class Star : MonoBehaviour {
	public float start;
	public float rate;
	// Use this for initialization
	void Start () {
		transform.localScale = new Vector3(start, start, start);
	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale += ((new Vector3 (rate,rate,rate)) *Time.deltaTime);
	}
}
