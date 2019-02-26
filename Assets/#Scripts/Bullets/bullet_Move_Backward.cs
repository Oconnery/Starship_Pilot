using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_Move_Backward : MonoBehaviour {

    public float maxSpeed;

    private void Start()
    {
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, 90f); 
    }

    // Update is called once per frame
    void Update(){

        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, maxSpeed * Time.deltaTime, 0);

        pos += transform.rotation * velocity;
        transform.position = pos;
    }
}
