using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityChange : MonoBehaviour {
    public AreaEffector2D gravityArea;
    int time = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (time >= 240)
        {
            time = 0;
          
        }

        time += 1;
        gravityArea.forceMagnitude = 0;
        if(time>=120) gravityArea.forceMagnitude = 35;


    }
}
