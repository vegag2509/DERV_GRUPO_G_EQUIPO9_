using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S3_Practica5 : MonoBehaviour
{
    Renderer rend;
    [SerializeField] Material color;
    [SerializeField] Material color2;
    [SerializeField] Material color3;
    int estado;

    // Start is called before the first frame update
    void Start()
    {
        estado = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (estado == 0)
            {
                GetComponent<Renderer>().material = color2;
                estado = 1;
            }
            else if (estado == 1)
            {
                GetComponent<Renderer>().material = color3;
                estado = 2;
            }
            else if (estado == 2)
            {
                GetComponent<Renderer>().material = color;
                estado = 0;
            }

        }
    }

}
