using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class EscapeTimeKeeper : MonoBehaviour {
    float levelTimer;
    private float startTime;
    Text timerText;
    void Start ()
    {
        startTime = Time.time;
        levelTimer = 60;
        timerText = GetComponent<Text>();
        timerText.text = "Escape sucessful in " + (int)(levelTimer) + " seconds!";
    }
	
	// Update is called once per frame
	void Update () {
        timerText.text = "Escape sucessful in " + (int)(levelTimer+startTime - Time.time) + " seconds!";
        if (Time.time > (levelTimer+startTime)) SceneManager.LoadScene("scenes/gameover");
    }
}
