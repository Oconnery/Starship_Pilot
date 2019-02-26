using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_Movement : MonoBehaviour {

    //enemies should move up and down every few seconds. 

    //if there are no enemies within a certain distance Y, the enemy should move up or down a certain amount. That number should never put them out of bounds. 
    //in update, if there are enemies within a certain distance, stop moving that way. Move the other direction.

        //do all ships move at the same speed? no. Add speed in later

    public float moveByY; //different ship types should move different amounts
    private float moveByYInverse;
    private float movementCount;
    public float movementSpeed;
    public float time;
    private float timer; //different ship types should have different timers

    private bool shouldMove;

    private float simpleCount;

	// Use this for initialization
	void Start () {
        moveByYInverse = -moveByY;
        movementCount = 0.0f;
        timer = time;
        shouldMove = false;
        simpleCount = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        simpleCount += 1f;
        //Debug.Log(simpleCount);

        //move a little bit every frame
        if (timer <= 0)
        {
           // Debug.Log("should move true");
            shouldMove = true;
        }

        if (shouldMove == true && movementCount <= moveByY)
        {
            //lets move 1 unit every 100 frames
            movementCount += movementSpeed;
            Vector3 pos = new Vector3 (0.0f,movementSpeed,0.0f);
            transform.position += pos;
            //Debug.Log(movementCount);
            if (movementCount == moveByY)
            {
                //Debug.Log("movement count is equal to move by y");
                shouldMove = false;
                movementCount = 0.0f;
                timer = time;
            }
        }

        timer -= Time.deltaTime;
	}

    private void Move()
    {
        //Check if the
    }


}
