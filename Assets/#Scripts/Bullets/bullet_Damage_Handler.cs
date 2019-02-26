using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_Damage_Handler : MonoBehaviour {


    public int lives;
    private bool shouldSpawn;

    void Start()
    {
        lives = 1;
        shouldSpawn = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Bullet collided with: " + collision.name);
        if (collision.name != "player_Character")
        {
            Debug.Log("Bullet dead");
            lives--;
            shouldSpawn = true;
        }
    }

    private void Update()
    {
        //Die is called here because update happens every frame.
        if (shouldSpawn == true)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        //Sound effect? 
    }
}
