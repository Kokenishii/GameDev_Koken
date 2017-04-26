using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubes : MonoBehaviour {
    float theta = 0;
    float radius = 1;
    float cubeSpeed;
    // Use this for initialization
    void Start () {
     theta = Random.Range(0,3.14f);
        radius = Random.Range(0.6f, 0.8f);
       cubeSpeed = Random.Range(80f, 100f);
    }
	
	// Update is called once per frame
	void Update () {
      
        gameObject.transform.Rotate(new Vector3(1,1,1));
        gameObject.transform.localPosition =  new Vector3(radius*Mathf.Cos(theta), transform.localPosition.y, radius*Mathf.Sin(theta));
        theta += 3.14f/cubeSpeed;
        if(theta>=6.28)
        {
            theta = 0;
        }

	}
}
