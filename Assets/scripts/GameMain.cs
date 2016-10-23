using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMain : MonoBehaviour {
	public static float speed;
	public static bool chaseMode;
	public float setSpeed;
	public bool setChaseMode;
	public GameObject bunnyPrefab;
	public GameObject gangsterPrefab;
    public GameObject housePrefabLeft;
    public GameObject housePrefabRight;
	public GameObject spikestripPrefab;
    public GameObject policePrefab;
    public float houseCooldown;
    private float houseTimestamp;
	public float bunninity;
	public float gangsterinity;
	public float spikiness;
   


	// Use this for initialization
	void Start () {
		chaseMode = setChaseMode;
		speed = setSpeed;
	    houseTimestamp = 0;
	    houseCooldown = 5;

	}

	void Update(){
		if (chaseMode) {
			ObstacleProcessor ();
		} else {
			GansterProcessor ();
			BunnyProcessor ();
		}
	    HouseProcessor();
		if (Input.GetKey("escape"))
			Application.Quit();
      
	}

    void HouseProcessor()
    {
        if (Time.time - houseCooldown > houseTimestamp)
        {

            GameObject houseLeft = Instantiate(housePrefabLeft);
            DontDestroyOnLoad(houseLeft);
            GameObject houseRight = Instantiate(housePrefabRight);
            DontDestroyOnLoad(houseRight);
            houseTimestamp = Time.time;
        }

    }

    void BunnyProcessor()
    {
        float number = Random.value;
        float chanceOfBunny = Time.deltaTime * bunninity;
        if (chanceOfBunny > number)
        {
            GameObject bunnyGo = Instantiate(bunnyPrefab);
            DontDestroyOnLoad(bunnyGo);
        }
    }
	void GansterProcessor()
	{
		float number = Random.value;
		float chanceOfGangster = Time.deltaTime * gangsterinity;
		if (chanceOfGangster > number)
		{
			GameObject gangsterGO = Instantiate(gangsterPrefab);
            DontDestroyOnLoad(gangsterGO);
        }
	}

	void ObstacleProcessor()
	{
		float number = Random.value;
		float chanceOfObstacle = Time.deltaTime * spikiness;
		if (chanceOfObstacle > number)
		{
            GameObject gangsterGO = Instantiate(policePrefab);
            //GameObject gangsterGO = Instantiate(spikestripPrefab);
			DontDestroyOnLoad(spikestripPrefab);
		}
	}
}
