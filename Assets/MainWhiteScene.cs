using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainWhiteScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
 public void EnterBlackScene()
    {
        SceneManager.LoadScene("Scene1");
    }
    public void EnterWhiteScene()
    {
        SceneManager.LoadScene("whiteScene2");
    }
}
