using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windControl : MonoBehaviour {
    public GameObject umbrella;
    public AreaEffector2D windArea;
    float originalForce;
    public float windValue = 4.5f;
	// Use this for initialization
	void Start () {
        originalForce = windArea.forceMagnitude;
    }
	
	// Update is called once per frame
	void Update () {
        if (umbrella.activeSelf)
        {
            
            windArea.forceMagnitude = originalForce*windValue;
        }
        else
        {
            windArea.forceMagnitude = originalForce;
        }
	}
}
