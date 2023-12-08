using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StupidMode_UI : MonoBehaviour
{
    public GameObject stupidMode;
    public TextMeshProUGUI textDisplay;
    
    // Start is called before the first frame update
    void Start()
    {
        stupidMode.SetActive(false); //this and same one below in if statement was "old me trying to get it to work"
        textDisplay.gameObject.SetActive(false); //this is me trying to figure out tmpro code also
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) {
            
            stupidMode.SetActive(true); 
            textDisplay.gameObject.SetActive(true);
        }
    }
}
