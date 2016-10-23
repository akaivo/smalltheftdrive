using UnityEngine;
using System.Collections;

public class GameMain : MonoBehaviour {
	public static float speed;
	public static bool chaseMode;
	public float setSpeed;
	public bool setChaseMode;
	public GameObject bunnyPrefab;
	public GameObject gangsterPrefab;
    public GameObject housePrefabLeft;
    public GameObject housePrefabRight;
    public float houseCooldown;
    private float houseTimestamp;
	public float bunninity;
	public float gangsterinity;

	// Use this for initialization
	void Start () {
		chaseMode = setChaseMode;
		speed = setSpeed;
	    houseTimestamp = 0;
	    houseCooldown = 5;
	}

	void Update(){
		GansterProcessor ();
        BunnyProcessor();
	    HouseProcessor();
		if (Input.GetKey("escape"))
			Application.Quit();
	}

    void HouseProcessor()
    {
        if (Time.time - houseCooldown > houseTimestamp)
        {

            GameObject houseLeft = Instantiate(housePrefabLeft);
            GameObject houseRight = Instantiate(housePrefabRight);
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
        }
    }
	void GansterProcessor()
	{
		float number = Random.value;
		float chanceOfGangster = Time.deltaTime * gangsterinity;
		if (chanceOfGangster > number)
		{
			GameObject gangsterGO = Instantiate(gangsterPrefab);
		}
	}
}
