using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PoliceCar : MonoBehaviour
{
    private float[] coords = {-2.63f, -0.97f, 0.97f, 2.72f};
	// Use this for initialization
	void Start ()
	{
	    int pos = Random.Range(0, 4);
        transform.position = new Vector3(coords[pos], 10, 0);
    }
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position += Vector3.down * GameMain.speed * Time.deltaTime;
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "car")
        {
            Destroy(coll.gameObject);
        }
        SceneManager.LoadScene("scenes/gameover");
    }

}
   
