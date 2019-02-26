using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player_Damage_Handler : MonoBehaviour {

    public bool shouldSpawn;

    public AudioClip explosion;

    public GameObject shieldObj;
    private GameObject shieldInstance;

    public float invulnPeriod;
    private float invulnTimer;

    SpriteRenderer spriteRend;

    private static float shieldCooldown;
    public static float shieldTimer;

    void Start(){
        invulnTimer = 0;
        invulnPeriod = 0.8f;
        spriteRend = GetComponent<SpriteRenderer>();
        shieldCooldown = 10f;
        shieldTimer = 0;

        if (spriteRend == null){
            Debug.LogError("Object " + gameObject.name + " has no sprite renderer.");
        }

        shouldSpawn = false;

        if (invulnPeriod > 0)
        {
            invulnTimer = invulnPeriod;
            gameObject.layer = 10;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision){

        //Debug.Log("Player Collided with: " + collision.name);
        if (collision.gameObject.layer != 11) //11 is pickup layer
        {
            //Respawn
            shouldSpawn = true;
        }
    }

    private void Update(){
        shieldTimer -= Time.deltaTime;


        if (invulnTimer >0){
            invulnTimer -= Time.deltaTime;
        }
        if (invulnTimer <= 0) { 
            gameObject.layer = 8; //player is no. 8
            spriteRend.enabled = true;
            if (shieldInstance != null)
            Destroy(shieldInstance);
        }
        else{
            spriteRend.enabled = !spriteRend.enabled;
            }
        

        if (shouldSpawn == true){
            Die();

            if (player_Lives.lives <= 0){
                SceneManager.LoadScene(4);
                //Load game over screen GUI
            }
        }

        if (Input.GetButtonDown("Fire2") && shieldTimer <= 0){
            invulnTimer = invulnPeriod;
            gameObject.layer = 10; //invuln layer
            shieldInstance = (GameObject) Instantiate(shieldObj, gameObject.transform);
            shieldTimer = shieldCooldown;

        }
    }

    void Die (){
        player_Lives.lives--;
        Destroy(gameObject);
        AudioSource.PlayClipAtPoint(explosion, new Vector3(0.0f, 0.0f, 0.0f));
        
        // Explosion particle effect
        // Sound effect(s) - Eugh and Boom
    }
}
