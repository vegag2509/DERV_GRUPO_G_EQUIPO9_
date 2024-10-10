using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast_Enemigo : MonoBehaviour
{
    [SerializeField] Transform jugador;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccion = jugador.position - transform.position;
        direccion = direccion.normalized; //magnitud
        RaycastHit hit;  // hit almacena la información de la colision
        if (Physics.Raycast(transform.position, direccion, out hit, 8f)) 
        {
            Debug.Log(direccion + "Erigei");
            Debug.DrawLine(transform.position, direccion * hit.distance * 8f, Color.red);

        }
        else
        {
            Debug.Log("noErigei");
            Debug.DrawLine(transform.position, direccion * hit.distance * 8f, Color.blue);
        }
    }
}
