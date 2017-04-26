using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeLocal : MonoBehaviour {
   public GameObject umbrella;
    Vector3 refV;
	// Use this for initialization
	void Start () {
      
        
	}
	
	// Update is called once per frame
	void Update () {
		if(umbrella.activeSelf)
        {
            transform.Rotate(new Vector3(0,-4,1));
            transform.localPosition = Vector3.SmoothDamp(transform.localPosition, new Vector3(0,1.5f,0),ref refV,0.2f);


                }
  else
        {
            transform.Rotate(new Vector3(0, 0, 0));
            transform.localPosition = Vector3.SmoothDamp(transform.localPosition, new Vector3(0, 0, 0), ref refV, 0.2f);
        }
    }
}
