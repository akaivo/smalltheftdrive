using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartGane : MonoBehaviour
{

    public void runGame()
    {
        GameObject main = GameObject.Find("GameMain");
        Destroy(main);
        SceneManager.LoadScene("scenes/main");

    }
}