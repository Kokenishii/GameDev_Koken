using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switch1 : MonoBehaviour {
    public AreaEffector2D gravityChange;
    public Color switchOnColor;
    public AudioSource triggerSound;
    // Use this for initialization
    void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {
      

    }

    void OnTriggerEnter2D(Collider2D umbrella)
    {
        triggerSound.Play();
        if (umbrella.name== "UmbrellaTop")
        {
            if (gravityChange.colliderMask != 0)
            { gravityChange.colliderMask = 0;
  
                GetComponent<SpriteRenderer>().color = switchOnColor; }
            else
            { gravityChange.colliderMask = 1;
                GetComponent<SpriteRenderer>().color = new Color(255,61,57); 
            }
        }
       
            }
}
