using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeScript : MonoBehaviour {
    bool toGrow = false;
   Vector3 refV;
   public Vector3 growScale;
    public GameObject gravityZone;
    public GameObject gravityIndicator;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(toGrow)
        {
            transform.localScale = Vector3.SmoothDamp(transform.localScale,growScale, ref refV,2f);
            transform.rotation = Quaternion.Lerp(transform.rotation, new Quaternion(0, 2, 0, 0), 0.1f * Time.deltaTime);
           
            gravityIndicator.SetActive(true);
        }
      
    }
    void OnTriggerEnter2D(Collider2D umbrella)
    {
  
        if(umbrella.name== "umbrellaIndicator")
        {
            Debug.Log("grow");
            gravityZone.SetActive(true);
            toGrow = true;
        }
    }
    void OnTriggerExit2D(Collider2D umbrella)
    {

        if (umbrella.name == "umbrellaIndicator")
        {
            Debug.Log("grow");
            toGrow = false;
        }
    }
}
