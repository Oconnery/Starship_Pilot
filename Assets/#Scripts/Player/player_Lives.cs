using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_Lives : MonoBehaviour {

    public static int lives;
    public Text livesText;
    private static int livesTemp;

    // Use this for initialization
    void Start () {
        livesText = GameObject.Find("Lives").GetComponent<Text>();
        lives = 3;
        livesTemp = lives;
        setLivesText();
    }
	
	// Update is called once per frame
	void Update () {
		if (livesTemp!=lives){
            setLivesText();
            livesTemp = lives;
        }
	}

    void setLivesText()
    {
        livesText.text = "Lives: " + lives.ToString();
    }
}
