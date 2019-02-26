using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
    public void mainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void newGame()
    {
        SceneManager.LoadScene(1);
    }

    public void levelSelector()
    {
        SceneManager.LoadScene(2);
    }

    public void exitGame()
    {
        Application.Quit();
    }

}
