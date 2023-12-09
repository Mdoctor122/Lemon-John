using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomiesSprint : MonoBehaviour
{
    public bool Schmoving = false;
    public float movementSpeed = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            Schmoving = true;
        }

        if (Input.GetKeyUp("w"))
        {
            Schmoving = false;
        }

        if (Input.GetKey(KeyCode.RightShift) & Schmoving == true)
        {
            transform.position += transform.forward * Time.deltaTime * movementSpeed;
        }
        if (Input.GetKeyDown("a"))
        {
            Schmoving = true;
        }

        if (Input.GetKeyUp("a"))
        {
            Schmoving = false;
        }

        if (Input.GetKey(KeyCode.RightShift) & Schmoving == true)
        {
            transform.position += transform.forward * Time.deltaTime * movementSpeed;
        }
            if (Input.GetKeyDown("s"))
            {
                Schmoving = true;
            }

            if (Input.GetKeyUp("s"))
            {
                Schmoving = false;
            }

            if (Input.GetKey(KeyCode.RightShift) & Schmoving == true)
            {
                transform.position += transform.forward * Time.deltaTime * movementSpeed;
            }
            if (Input.GetKeyDown("d"))
            {
                Schmoving = true;
            }

            if (Input.GetKeyUp("d"))
            {
                Schmoving = false;
            }

            if (Input.GetKey(KeyCode.RightShift) & Schmoving == true)
            {
                transform.position += transform.forward * Time.deltaTime * movementSpeed;
            }
    }
}
