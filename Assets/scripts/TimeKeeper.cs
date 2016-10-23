using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEditor;
using UnityEngine.SceneManagement;

public class TimeKeeper : MonoBehaviour
{
    private DataHandler handler;
    private int score;
    float levelTimer;
    Text timerText;
    void Start () {
        handler = new DataHandler();
        levelTimer = 15;
        timerText = GetComponent<Text>();
        timerText.text = "Police arrives in "+levelTimer + " seconds!";
    }
	
	// Update is called once per frame
	void Update ()
	{
	    timerText.text = "Police arrives in " + (int)(levelTimer - Time.time) + " seconds!";
        if (Time.time > levelTimer) SwapScenes();
    }

    public void setScore(int score)
    {
        this.score = score;
    }

    void SwapScenes()
    {
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


        SceneManager.LoadScene("scenes/chase");
    }
}
