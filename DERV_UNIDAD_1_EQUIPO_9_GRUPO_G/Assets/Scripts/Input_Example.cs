using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_Example : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Hola A");
        }
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Hola W");
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Hola S");
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Hola D");
        }


    }
}
