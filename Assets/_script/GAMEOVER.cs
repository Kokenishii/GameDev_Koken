using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GAMEOVER : MonoBehaviour {
    public Text gameOver;
    bool gameOverStatus = false;
	// Use this for initialization
	void Start () {
        GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if(gameOverStatus)
        {
            gameOver.gameObject.SetActive(true);
        }
	}
   void OnTriggerEnter2D()
    {
        gameOverStatus = true;
      

    }
    void OnTriggerExit2D()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
