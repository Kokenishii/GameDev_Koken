using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switch1 : MonoBehaviour {
    public AreaEffector2D gravityChange;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D umbrella)
    {
        if(umbrella.name== "UmbrellaTop")
        {
            if (gravityChange.colliderMask != 0)
            { gravityChange.colliderMask = 0; }
            else
            { gravityChange.colliderMask = 1; }
        }
       
            }
}
