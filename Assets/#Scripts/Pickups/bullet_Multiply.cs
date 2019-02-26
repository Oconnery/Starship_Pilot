using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_Multiply : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            player_Shoot.fire = 2;
            Destroy(gameObject);
        }
    }
}