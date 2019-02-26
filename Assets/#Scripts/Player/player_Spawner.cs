using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_Spawner : MonoBehaviour {

    public GameObject playerPrefab;
    GameObject playerInstance;
    float respawnTimer;

	// Use this for initialization
	void Start () {
        //spawnPlayer();
	}
	
	// Update is called once per frame
	void Update () {
        if (playerInstance == null){
            respawnTimer -= Time.deltaTime;

            if(respawnTimer <= 0) {
                Debug.Log("Player should spawn");
                spawnPlayer();
            }
        }
	}

    void spawnPlayer(){
        respawnTimer = 1;
        playerInstance = (GameObject)Instantiate(playerPrefab, transform.position, Quaternion.Euler(0.0f, 0.0f, 270f));
    }
}
