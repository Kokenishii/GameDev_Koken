using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class helpScript : MonoBehaviour
{

    public Text helpText;

    // Use this for initialization
    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D()
    {

        helpText.gameObject.SetActive(true);

        
    }
    void OnTriggerExit2D()
    {

        helpText.gameObject.SetActive(false);


    }
}