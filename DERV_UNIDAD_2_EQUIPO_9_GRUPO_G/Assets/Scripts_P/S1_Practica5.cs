using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S1_Practica5 : MonoBehaviour
{
    public float velocidadMovimiento = 10f;
    [SerializeField] Transform origen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //mover arriba y abajo 
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.forward * velocidadMovimiento * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(transform.forward * -1 * velocidadMovimiento * Time.deltaTime);
        }

        //mover izquierda y derecha
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(transform.right * -1 * velocidadMovimiento * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right * velocidadMovimiento * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.R)) {
            transform.position = origen.transform.position;
        }
    }
}
