using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class TimeKeeper : MonoBehaviour {

    float levelTimer;
    Text timerText;
    void Start () {
        levelTimer = 65;
        timerText = GetComponent<Text>();
        timerText.text = "Police arrives in "+levelTimer + " seconds!";
    }
	
	// Update is called once per frame
	void Update ()
	{
	    timerText.text = "Police arrives in " + (int)(levelTimer - Time.time) + " seconds!";
        if (Time.time > levelTimer) SceneManager.LoadScene("scenes/chase");
    }
}
