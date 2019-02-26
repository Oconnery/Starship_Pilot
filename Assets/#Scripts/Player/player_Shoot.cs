using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_Shoot : MonoBehaviour {

    private GameObject bulletPrefab;

    public GameObject slugPrefab;
    public GameObject laserPrefab;
    public Vector3 bulletOffset;
    public Vector3 bulletOffsetFirst;
    public Vector3 bulletOffsetSecond;

    // Need to change firedelay depending on weapon equipped
    public float fireDelay;
    private float cooldownTimer;
    public static int fire; //fire 2 bullets?

    // Use this for initialization
    void Start () {
        bulletPrefab = slugPrefab;
        fire = 1;
        cooldownTimer = 0f;
        fireDelay = 0.25f;
        bulletOffset = new Vector3(0.0f, 2.0f, 0.0f);
        bulletOffsetFirst = new Vector3(-0.15f, 2.0f, 0.0f);
        bulletOffsetSecond = new Vector3(0.15f, 2.0f, 0.0f);
    }
	
	// Update is called once per frame
	void Update () {
        fireDelay -= Time.deltaTime;

		if (Input.GetButtonDown("Fire1") && fireDelay <= 0f)
        {
            if (fire == 1)
            {
                Vector3 offset = transform.rotation * bulletOffset;
                Instantiate(bulletPrefab, transform.position + offset, Quaternion.Euler(transform.position));
            } else if (fire == 2)
            {
                Vector3 offset = transform.rotation * bulletOffsetFirst;
                Vector3 offsetTwo = transform.rotation * bulletOffsetSecond;
                Instantiate(bulletPrefab, transform.position + offset, Quaternion.Euler(transform.position));
                Instantiate(bulletPrefab, transform.position + offsetTwo, Quaternion.Euler(transform.position));
            }
            fireDelay = 0.25f;
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Pickup collisions
        if (collision.tag == "laser_Pickup") {
            Debug.Log("Worked");
            bulletPrefab = laserPrefab;
        }
    }

    void increaseScoreMultiplier()
    {

    }
}