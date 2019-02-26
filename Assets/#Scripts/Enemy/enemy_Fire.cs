using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_Fire : MonoBehaviour {

    public GameObject bulletPrefab;
    public float fireDelay;
    private float fireDelayTemp;
    private int bulletsFired;
    public int numberToFire;
    public float pause;
    private float pauseTemp;
    public Vector3 bulletOffset;

    // Use this for initialization
    void Start () {
        // use case here for fireDelay for different types of ships
        pauseTemp = pause;
        pause += fireDelay;
        fireDelayTemp = fireDelay;
        bulletsFired = 0;
    }
	
	// Update is called once per frame
	void Update () {
        fireDelay -= Time.deltaTime;

        if (fireDelay <= 0f)
        {
            switch (gameObject.tag)
            {
                case "Destroyer":
                    Destroyer();
                    break;
                case "Flamer":
                    Flamer();
                    break;
                case "Rocketer":
                    Rocketer();
                    break;
                case "Vessel":
                    Vessel();
                    break;
                case "MiniDestroyer":
                    MiniDestroyer();
                    break;
                case "Blaster":
                    Blaster();
                    break;
            }
        }
    }

    void Destroyer()
    {
        //Fast
        if (bulletsFired < numberToFire)
        {
            //Fast burst with pauses 8 bullets then pause 
            Vector3 offset = transform.rotation * bulletOffset;
            Instantiate(bulletPrefab, transform.position + offset, Quaternion.Euler(transform.position));
            bulletsFired++;
            fireDelay = fireDelayTemp;
        }
        else
        {
            pause -= Time.deltaTime;
            if (pause <= 0.0f)
            {
                bulletsFired = 0;
                pause = pauseTemp;
            }
        }
    }

    void Flamer()
    {
        //Flamer is oriented at 270 degrees instead of 90 degrees like the other enemies. Its xyz are different.
        if (bulletsFired < numberToFire)
        {
            //Fast burst with pauses 8 bullets then pause 
            Vector3 offset = transform.rotation * bulletOffset;
            Instantiate(bulletPrefab, transform.position + offset, Quaternion.Euler(transform.position));
            bulletsFired++;
            fireDelay = fireDelayTemp;
        }
        else
        {
            pause -= Time.deltaTime;
            if (pause <= 0.0f)
            {
                bulletsFired = 0;
                pause = pauseTemp;
            }
        }
        //Instead of this have "Activate particle effect"
    }

    void Rocketer()
    {
        //fast
        if (bulletsFired < numberToFire)
        {
            //Fast burst with pauses 8 bullets then pause 
            Vector3 offset = transform.rotation * bulletOffset;
            Instantiate(bulletPrefab, transform.position + offset, Quaternion.Euler(transform.position));
            bulletsFired++;
            fireDelay = fireDelayTemp;
        }
        else
        {
            pause -= Time.deltaTime;
            if (pause <= 0.0f)
            {
                bulletsFired = 0;
                pause = pauseTemp;
            }
        }
        //Fire rockets
    }

    void Vessel()
    {
        //medium fire rate
        if (bulletsFired < numberToFire)
        {
            //Fast burst with pauses 8 bullets then pause 
            Vector3 offset = transform.rotation * bulletOffset;
            Instantiate(bulletPrefab, transform.position + offset, Quaternion.Euler(transform.position));
            bulletsFired++;
            fireDelay = fireDelayTemp;
        }
        else
        {
            pause -= Time.deltaTime;
            if (pause <= 0.0f)
            {
                bulletsFired = 0;
                pause = pauseTemp;
            }
        }
    }

    void MiniDestroyer()
    {
        if (bulletsFired < numberToFire)
        {
            //Fast burst with pauses 8 bullets then pause 
            Vector3 offset = transform.rotation * bulletOffset;
            Instantiate(bulletPrefab, transform.position + offset, Quaternion.Euler(transform.position));
            bulletsFired++;
            fireDelay = fireDelayTemp;
        }
        else
        {
            pause -= Time.deltaTime;
            if (pause <= 0.0f)
            {
                bulletsFired = 0;
                pause = pauseTemp;
            }
        }
    }

    void Blaster()
    {
        if (bulletsFired < numberToFire)
        {
            //Fast burst with pauses 8 bullets then pause 
            Vector3 offset = transform.rotation * bulletOffset;
            Instantiate(bulletPrefab, transform.position + offset, Quaternion.Euler(transform.position));
            bulletsFired++;
            fireDelay = fireDelayTemp;
        }
        else
        {
            pause -= Time.deltaTime;
            if (pause <=0.0f)
            {
                bulletsFired = 0;
                pause = pauseTemp;
            }
        }
    }
}