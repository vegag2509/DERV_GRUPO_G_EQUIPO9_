using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientoenemigos : MonoBehaviour
{
    Transform ubi_Personaje;
    private void Awake()
    {
        ubi_Personaje = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        float velocidad = 5.0f * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, ubi_Personaje.position, velocidad);
    }
}
