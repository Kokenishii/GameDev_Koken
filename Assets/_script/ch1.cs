using System.Collections;
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
    float dressBending0;
    float dressStretching0;
    // Use this for initialization
    void Start () {
        ch = GetComponent<Rigidbody2D>();
        umbrellaOn = true;
        ch.drag = dragValue;
        float dressBending0 = dress.bendingStiffness;
        float dressStretching0 = dress.stretchingStiffness;
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
              //  umbrella.SetActive(true);
                dress.bendingStiffness = dressBending;
                dress.stretchingStiffness = dressStretching;

            }
            else
            {
                ch.drag = 0;
               // ch.mass = 4;
                umbrellaOn = false;
               //umbrella.SetActive(false);
                dress.bendingStiffness = dressBending0;
                //dress.stretchingStiffness = dressStretching0;
                dress.stretchingStiffness = 0.9f;
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
