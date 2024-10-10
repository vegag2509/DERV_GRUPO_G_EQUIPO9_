using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.UIElements;

public class movimiento : MonoBehaviour
{

    [SerializeField] float velocidad = 5;

    Transform target;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            // transform.position = transform.forward * velocidad * Time.deltaTime;
            transform.position += transform.forward * velocidad * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            //transform.Translate(transform.forward * velocidad * -1 * Time.deltaTime);
            transform.position = transform.forward * -1 * velocidad * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            //transform.Translate(transform.right * velocidad * -1 * Time.deltaTime);
            transform.position = transform.right * -1 * velocidad *  Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            //transform.Translate(transform.right * velocidad * Time.deltaTime);
            transform.position = transform.right * velocidad * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(Vector3.zero, Vector3.up, 60 * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(Vector3.zero, Vector3.up * -1, 60 * Time.deltaTime);
        }


    }
}
