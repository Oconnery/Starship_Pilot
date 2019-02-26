using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage_Multiply : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
            doubleDmg();
        }
    }

    void doubleDmg()
    {
        enemy_Damage_Handler.damageMultiplier = 2;
    }
}
