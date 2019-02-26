using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class self_Destruct : MonoBehaviour {

    public float timer = 5f;



	// Use this for initialization
	void Start () {
        Destroy(gameObject, timer);	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
