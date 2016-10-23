using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public Text timeText;
    private DataHandler handler;
	public static int score = 0;
	Text scoreText;
	// Use this for initialization
	void Start () {
        handler = new DataHandler();
        handler.Load();
	    score = handler.money;
		scoreText = GetComponent<Text> ();
		scoreText.text = "$: "+score;
	}
	
	// Update is called once per frame
	void Update () {
        timeText.SendMessage("setScore",score);
		scoreText.text = "$: " + score;
	}
}
