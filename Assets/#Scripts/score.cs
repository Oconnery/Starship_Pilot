﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    public static long scoreValue;
    public Text Score;

	// Use this for initialization
	void Start () {
        scoreValue = 0;
	}
	
	// Update is called once per frame
	void Update () {
        Score.text = "Score: " + scoreValue.ToString();
	}
}

