using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winScreen : MonoBehaviour {
    public Text gameWin;
    bool gameWinStatus = false;
    // Use this for initialization
    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameWinStatus)
        {
            gameWin.gameObject.SetActive(true);
        }
    }
    void OnTriggerEnter2D()
    {
        gameWinStatus = true;
        Application.LoadLevel("mainTitle");

    }
    //void OnTriggerExit2D()
    //{
    //    Application.LoadLevel(Application.loadedLevel);
    //}
}
