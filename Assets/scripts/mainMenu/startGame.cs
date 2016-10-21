using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour {

    public void runGame()
    {
        SceneManager.LoadScene("scenes/main");
    }
}
