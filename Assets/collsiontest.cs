using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collsiontest : MonoBehaviour {
    public
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
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
