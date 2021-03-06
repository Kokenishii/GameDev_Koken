﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ch1 : MonoBehaviour {
    public Rigidbody2D ch;
 
    bool canJump = false;
    public float dragValue,massValue;
    bool umbrellaOn = false;
    public GameObject umbrella;
    public float speed = 1;
    public float jumpSpeed = 1.8f;
    public Cloth dress;
    public float dressBending;
    public float dressStretching;
    public GameObject umbrellaIndicator;
    float dressBending0;
    float dressStretching0;
    public float landSpeed;
  public Camera mainCamera;
    float refVelocity;
public float rotateBound;
   public float rotateAdd;
    int t = 0;
    public float turnAdd;
    bool shouldTurn = false;
    // Use this for initialization
    void Start () {
        ch = GetComponent<Rigidbody2D>();
        umbrellaOn = false;
        ch.drag = dragValue;
        float dressBending0 = dress.bendingStiffness;
        float dressStretching0 = dress.stretchingStiffness;

    }
	
	// Update is called once per frame
	void Update () {
   
             float moveHor = Random.Range(Input.GetAxis("Horizontal")-0.1f, Input.GetAxis("Horizontal")+0.1f);
        if (!Input.GetKey(KeyCode.A)&&!Input.GetKey(KeyCode.D))
        {
            moveHor = 0;
        }
            // float moveVer = Input.GetAxis("Vertical");

            ch.velocity = new Vector3(moveHor*speed, ch.velocity.y);
        //if (Input.GetKeyUp(KeyCode.D))
        //{
        //    shouldTurn = true;
        //}
        Camera thisCamera = mainCamera.GetComponent<Camera>();
        thisCamera.fieldOfView = Mathf.SmoothDamp(thisCamera.fieldOfView, 50 + ch.velocity.y * 0.5f, ref refVelocity, 1f);
        //if(!canJump)
        //{
        //    Camera thisCamera = mainCamera.GetComponent<Camera>();
        //    if (ch.velocity.y > 0)
        //    {
        //        thisCamera.fieldOfView += 0.1f;
        //    }
        //    else
        //    {
        //        if (ch.velocity.y < 0)
        //        {
        //            thisCamera.fieldOfView -= 0.5f;
        //        }
        //    }
        //}
        if (canJump && moveHor!=0)
        { 
        ch.transform.Rotate(0f, rotateAdd, 0f);
        if (ch.transform.rotation.y >= rotateBound || ch.transform.rotation.y <= -rotateBound)
        {
            rotateAdd = -rotateAdd;
        }
        }

        ch.angularVelocity = 0;
        if (Input.GetKeyDown(KeyCode.W) && canJump)
        {
            ch.AddForce(new Vector2(0, 10 * jumpSpeed), ForceMode2D.Impulse);

        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(!umbrellaOn)
            {  //ch.gravityScale = 0.5f;
                ch.drag = dragValue;
                //ch.mass = massValue;
                umbrellaOn = true;
              umbrellaIndicator.SetActive(true);
                dress.bendingStiffness = dressBending;
                dress.stretchingStiffness = dressStretching;

            }
            else
            {
                ch.drag = 0;
               // ch.mass = 4;
                umbrellaOn = false;
                umbrellaIndicator.SetActive(false);
                dress.bendingStiffness = dressBending0;
                //dress.stretchingStiffness = dressStretching0;
                dress.stretchingStiffness = 0.9f;
            }
          
        }
        

    }
    void OnCollisionEnter2D()
    {
       // Debug.Log("!");
      
           canJump = true;
        ch.velocity = new Vector3(ch.velocity.x, ch.velocity.y - landSpeed);
      
    }
    void OnCollisionExit2D()
    {
      //  Debug.Log("?");
       canJump = false;
      
    }
    void turnAround()
    {
        if (transform.rotation.y>=175)
        {
            shouldTurn = false; }
        else
        {
            turnAdd = 1;
        ch.transform.Rotate(0f, turnAdd, 0f);
        }
            }
}
