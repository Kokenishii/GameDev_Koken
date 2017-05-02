using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GAMEOVER : MonoBehaviour {
    public Text gameOver;
    bool gameOverStatus = false;
    public GameObject player;
    Rigidbody2D playerBody;
    float cAcceleration;
    float lastVelocity;
    float countdown = 2;
    // Use this for initialization
    void Start () {
        GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
        playerBody = player.GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
		if(gameOverStatus)
        {
            gameOver.gameObject.SetActive(true);
            countdown -= Time.deltaTime;
          
            if(countdown<=0)
            {
                countdown = 2;
              
                Application.LoadLevel(Application.loadedLevel);
            }
        }
        cAcceleration = (playerBody.velocity.y - lastVelocity) / Time.fixedDeltaTime;
        lastVelocity = playerBody.velocity.y;
        Debug.Log(cAcceleration);
        if (cAcceleration >= 1000)
        {
           gameOverStatus = true;
        }
    }
   void OnTriggerEnter2D()
    {
    gameOverStatus = true;
      

    }
    void OnTriggerExit2D()
    {
        
    }
}
