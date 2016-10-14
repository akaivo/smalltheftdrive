using UnityEngine;
using System.Collections;

public class GameMain : MonoBehaviour {
	public static float speed;
	public float setSpeed;
	public GameObject bunnyPrefab;
    public GameObject housePrefabLeft;
    public GameObject housePrefabRight;
    public float houseCooldown;
    private float houseTimestamp;
	public float bunninity;

	// Use this for initialization
	void Start () {
		speed = setSpeed;
	    houseTimestamp = 0;
	    houseCooldown = 5;
	}

	void Update(){
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
}
