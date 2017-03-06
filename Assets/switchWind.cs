using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchWind : MonoBehaviour {
    public AreaEffector2D gravityChange;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D umbrella)
    {
        Debug.Log(umbrella.name);
        if (umbrella.name == "UmbrellaTop")
        {
            gravityChange.forceAngle = 180f;
        }

    }
}
