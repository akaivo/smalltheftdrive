﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class TimeKeeper : MonoBehaviour {

    float levelTimer;
    Text timerText;
    void Start () {
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

    void SwapScenes()
    {
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
