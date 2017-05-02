using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour {

    // Use this for initialization
    public GameObject thePlayer;
    public float positionOffsetY;
   
    //get the balloon(player)
    //create a text for gameOver
    //import the player object (balloon)

    //since the transform.position for camera will get a vector3, so I just use vector3(although it's 2D)

    private Vector3 velocity = Vector3.zero;
    //the smoothdamp function requires a ref velocity to handle
    public float smoothTime = 0.5f;
    //I want to control the time in which the camera SMOOTHLY moves to the target (balloon)
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
      
        Vector3 moveTo = new Vector3(thePlayer.transform.position.x, thePlayer.transform.position.y+ positionOffsetY, transform.position.z);
        //Create a new Vector3 which stores the value of the target of the camera (the Player)
        // transform.position = Vector3.Lerp(transform.position, moveTo, .08f);
        transform.position = Vector3.SmoothDamp(transform.position, moveTo, ref velocity, smoothTime);
        //from current "transform.position" to the desired position "moveTo", in 1 second, smoothly

    }
    void LateUpdate()
    {

        // transform.position = balloon.transform.position + lockRotate;
    }
}


