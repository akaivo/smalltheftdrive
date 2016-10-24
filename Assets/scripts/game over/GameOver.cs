using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour {

    public void mainMenu()
    {
        GameMain.chaseMode = true;
        GameObject back = GameObject.Find("Background");
        Destroy(back);
        GameObject back2 = GameObject.Find("Background (1)");
        Destroy(back2);
        GameObject car = GameObject.Find("car2");
        Destroy(car);
        GameObject road = GameObject.Find("Road");
        Destroy(road);
        GameObject road2 = GameObject.Find("Road (1)");
        Destroy(road2);
        GameObject main = GameObject.Find("GameMain");
        Destroy(main);
        SceneManager.LoadScene("scenes/mainMenu");
    }
}
