using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {
	public static int score = 0;
	Text scoreText;
	// Use this for initialization
	void Start () {
		scoreText = GetComponent<Text> ();
		scoreText.text = "$: 0";
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "$: " + score;
	}
}
