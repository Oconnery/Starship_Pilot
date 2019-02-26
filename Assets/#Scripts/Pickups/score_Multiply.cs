using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score_Multiply : MonoBehaviour {

    //Need to do this in player damage handler or the score script since this script disappears when object dies.
    
    private void Update()
    {

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            moreScore();
            Destroy(gameObject);
        }
    }

    private void moreScore()
    {
        enemy_Damage_Handler.scoreMultiplier = 2;
    }
}
