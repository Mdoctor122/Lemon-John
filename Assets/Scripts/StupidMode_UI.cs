using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StupidMode_UI : MonoBehaviour
{
    public GameObject stupidMode;
    
    // Start is called before the first frame update
    void Start()
    {
        stupidMode.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) {
            stupidMode.SetActive(true);
        }
    }
}
