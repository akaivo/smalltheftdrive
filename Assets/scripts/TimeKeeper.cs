using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class TimeKeeper : MonoBehaviour
{
    
    private DataHandler handler = new DataHandler();
    private int score;
    float levelTimer;
    private float startTime;
    Text timerText;
    void Start ()
    {

        startTime = Time.time;
        levelTimer = 60;
        timerText = GetComponent<Text>();
        timerText.text = "Police arrives in "+levelTimer + " seconds!";
    }
	
	// Update is called once per frame
	void Update ()
	{
	    timerText.text = "Police arrives in " + (int)(levelTimer+startTime - Time.time) + " seconds!";
        if (Time.time > (levelTimer+startTime)) SwapScenes();
    }

    public void setScore(int score)
    {
        this.score = score;
    }

    void SwapScenes()
    {
		GameMain.chaseMode = true;
        handler.money = score;
        handler.Save();
        GameObject back = GameObject.Find("Background");
        DontDestroyOnLoad(back);
        GameObject back2 = GameObject.Find("Background (1)");
        DontDestroyOnLoad(back2);
        GameObject car = GameObject.Find("car2");
        DontDestroyOnLoad(car);
        GameObject road = GameObject.Find("Road");
        DontDestroyOnLoad(road);
        GameObject road2 = GameObject.Find("Road (1)");
        DontDestroyOnLoad(road2);
		GameObject main = GameObject.Find ("GameMain");
		DontDestroyOnLoad (main);


       //if(SceneManager.GetActiveScene().name == "scenes/main")
            SceneManager.LoadScene("scenes/chase");
    }
}
