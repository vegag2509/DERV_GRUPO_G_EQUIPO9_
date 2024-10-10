using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class P1_Practica: MonoBehaviour
{
    [SerializeField] float velocidad_rotacion = 20f;
    [SerializeField] float velocidad_movimiento = 10f;
    [SerializeField] TextMeshProUGUI puntuacion;
    int puntos;

    private void OnCollisionEnter(Collision other)
    {
        GameObject obj = other.gameObject;
        if (obj.CompareTag("Point"))
        {
            Destroy(obj);
            puntos++;
            puntuacion.text = "Puntuación: " + puntos.ToString();
        }
        if(puntos >= 45)
        {
            if (obj.CompareTag("Finish"))
            {
                Destroy(obj);
                puntuacion.text = "JUEGO TERMINADO";
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        puntos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float angulo = 5f * velocidad_rotacion * Time.deltaTime;
         //rotar izquierda y derecha
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, angulo * -1, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, angulo, 0);
        }

        //mover arriba y abajo 
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.forward * velocidad_movimiento * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(transform.forward * -1 * velocidad_movimiento * Time.deltaTime);
        }
        //mover izquierda y derecha
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(transform.right * -1 *velocidad_movimiento * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right* velocidad_movimiento * Time.deltaTime);
        }


    }
}
