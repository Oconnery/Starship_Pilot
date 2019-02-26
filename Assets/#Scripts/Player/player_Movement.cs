using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_Movement : MonoBehaviour {

    //all vectors use floats so I should use float
    private float maxSpeedVertical;
    private float maxSpeedHorizontal;
    private float shipBoundaryRadiusVertical;
    private float shipBoundaryRadiusRight;
    private float shipBoundaryRadiusLeft;
    private Vector3 pos;

    // Use this for initialization
    void Start ()
    {
        maxSpeedVertical = 20f;
        //1920/1080 = 1.77777777778f; - will move just as quick across the screen as it does up screen
        maxSpeedHorizontal = maxSpeedVertical * 1.77777777778f;
        shipBoundaryRadiusVertical = 0.68f;//1.7f;
        shipBoundaryRadiusRight = 1.6f;//2.6f;
        shipBoundaryRadiusLeft = 1.6f;//3.6f;
        pos = transform.position;
    }
	
	// Update is called once per frame
	void Update ()
    {
        //Change it so I can't do both
        //Can't do if and else if because if two keys are held down at the same time it just depends on which one is read first by CPU.
        //So I have to use something other than GetAxis
        // Looks like I need to use the physics system to have gravity and sensitivity if I cant go horizontally and vertically at the same time

        if (Input.GetAxis("Vertical") != 0 && Input.GetAxis("Horizontal") != 1 && Input.GetAxis("Horizontal") != -1)
        {
            //Input.GetAxis Returns a float from -1.0 to 1.0 depending on direction.
            //Using delta time so I need to cap fps?
            pos.y += Input.GetAxis("Vertical") * maxSpeedVertical * Time.deltaTime;
            transform.position = pos;
        }

        if (Input.GetAxis("Horizontal") != 0 && Input.GetAxis("Vertical") != 1 && Input.GetAxis("Vertical") != -1)
        {
            pos.x += Input.GetAxis("Horizontal") * maxSpeedHorizontal * Time.deltaTime;
            transform.position = pos;
        }

        //Ship possible area = camera area
        //Vertical
        if (pos.y + shipBoundaryRadiusVertical > Camera.main.orthographicSize)
        {
            pos.y = Camera.main.orthographicSize - shipBoundaryRadiusVertical;
        }

        if (pos.y - shipBoundaryRadiusVertical < -Camera.main.orthographicSize)
        {
            pos.y = -Camera.main.orthographicSize + shipBoundaryRadiusVertical;
        }

        //Horizontal
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float widthOrthographicSize = Camera.main.orthographicSize * screenRatio;

        if (pos.x + shipBoundaryRadiusRight > widthOrthographicSize)
        {
            pos.x = widthOrthographicSize - shipBoundaryRadiusRight;
        }

        if (pos.x - shipBoundaryRadiusLeft < -widthOrthographicSize)
        {
            pos.x = -widthOrthographicSize + shipBoundaryRadiusLeft;
        }

        transform.position = pos;
    }

}