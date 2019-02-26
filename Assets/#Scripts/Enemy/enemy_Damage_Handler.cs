using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_Damage_Handler : MonoBehaviour {

    public int health;
    public AudioClip explosion;

    public static int scoreMultiplier;
    public static int damageMultiplier;

    void Start(){
        //score timer should definetly not be on the enemy damage handler or damage timer. They should be on HUD etc. damage multiplier and score multiplier variables should be here.
        scoreMultiplier = 1;
        damageMultiplier = 1;
    }

    private void OnTriggerEnter2D(){
             if (damageMultiplier == 2){
                 health--;
                 health--;
             } else
               health--;
    }

    private void Update(){
        if (health<=0){
            Die();
        }
    }

    void Die(){
        deadCheck.KilledOpponent(gameObject);
        AudioSource.PlayClipAtPoint(explosion, new Vector3 (0.0f, 0.0f, 0.0f));
        Destroy(gameObject);
        addScore();
        // Explosion particle effect
        // Sound effect(s) - Eugh and Boom
    }

    void addScore(){
        switch (gameObject.tag)
        {
            case "Destroyer":
                score.scoreValue += (100*scoreMultiplier);
                break;
            case "Rocketer":
                score.scoreValue += (125 * scoreMultiplier);
                break;
            case "MiniDestroyer":
                score.scoreValue += (75 * scoreMultiplier);
                break;
            case "Vessel":
                score.scoreValue += (175 * scoreMultiplier);
                break;
            case "Blaster":
                score.scoreValue += (350 * scoreMultiplier);
                break;
            case "Flamer":
                score.scoreValue += (200 * scoreMultiplier);
                break;
        }
    }
}
