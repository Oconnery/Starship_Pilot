using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deadCheck : MonoBehaviour {

    static List<GameObject> listOfEnemies = new List<GameObject>();

    void Start(){
        listOfEnemies.AddRange(GameObject.FindGameObjectsWithTag("Blaster"));
        listOfEnemies.AddRange(GameObject.FindGameObjectsWithTag("Destroyer"));
        listOfEnemies.AddRange(GameObject.FindGameObjectsWithTag("Flamer"));
        listOfEnemies.AddRange(GameObject.FindGameObjectsWithTag("MiniDestroyer"));
        listOfEnemies.AddRange(GameObject.FindGameObjectsWithTag("Rocketer"));
        listOfEnemies.AddRange(GameObject.FindGameObjectsWithTag("Vessel"));
        Debug.Log("Enemy Count: " + listOfEnemies.Count);
    }

    public static void KilledOpponent(GameObject enemy){
        if (listOfEnemies.Contains(enemy)){
            listOfEnemies.Remove(enemy);
        }

        Debug.Log("Enemy Count: " + listOfEnemies.Count);

        if (AreOpponentsDead())
            SceneManager.LoadScene(0);
    }

    public static bool AreOpponentsDead(){
        if (listOfEnemies.Count <= 0){
            // They are dead!
            return true;
        }
        else{
            // They're still alive
            return false;
        }
    }
}