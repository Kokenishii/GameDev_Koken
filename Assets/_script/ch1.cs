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
	// Use this for initialization
	void Start () {
        ch = GetComponent<Rigidbody2D>();
        umbrellaOn = true;
        ch.drag = dragValue; 
    }
	
	// Update is called once per frame
	void Update () {
        float moveHor = Input.GetAxis("Horizontal");
      // float moveVer = Input.GetAxis("Vertical");
        ch.velocity = new Vector3(moveHor*speed, ch.velocity.y);
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
                umbrella.SetActive(true);

            }
            else
            {
                ch.drag = 0;
               // ch.mass = 4;
                umbrellaOn = false;
               umbrella.SetActive(false);
            }
          
        }
        

    }
    void OnCollisionEnter2D()
    {
        Debug.Log("!");
      
           canJump = true;
        
    }
    void OnCollisionExit2D()
    {
        Debug.Log("?");
       canJump = false;
    }

}