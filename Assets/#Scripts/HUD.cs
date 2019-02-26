using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    public Text shieldCD;
    public Text scoreTxt;
    public Text dmgTxt;
    public Text bltTxt;
    private static float shieldCooldown;

    private static int scoreMult;
    public static float scoreTimer;

    private static int damageMult;
    public static float damageTimer;

    private static int bltMult;
    // Use this for initialization
    void Start () {
        scoreTimer = 0;
        damageTimer = 0;
    }
	
	// Update is called once per frame
	void Update () {
        shieldCooldown = player_Damage_Handler.shieldTimer;
        if (shieldCooldown >= 0){
            shieldCD.text = "Shield CD: " + shieldCooldown.ToString("F1");
        }

        UpdateScore();
        Print(scoreMult, scoreTxt, "2X Score");

        UpdateDmg();
        Print(damageMult, dmgTxt, "2X Damage");

        Print(player_Shoot.fire, bltTxt, "2X Bullets");
    }

    void Print(int mult, Text txt, string message){
        if (mult > 1){
            txt.text = message;
        }
        else if (mult <= 1){
            txt.text = "";
        }
    }

    void UpdateScore(){
        scoreMult = enemy_Damage_Handler.scoreMultiplier;
        if (scoreMult == 2)
        {
            scoreTimer += Time.deltaTime;
            if (scoreTimer >= 12)
            {
                scoreMult = 1;
                enemy_Damage_Handler.scoreMultiplier = 1;
            }
        }
    }

    void UpdateDmg(){
        damageMult = enemy_Damage_Handler.damageMultiplier;
        if (damageMult == 2)
        {
            damageTimer += Time.deltaTime;
            if (damageTimer >= 8)
            {
                damageMult = 1;
                enemy_Damage_Handler.damageMultiplier = 1;
            }
        }
    }
}
