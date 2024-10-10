using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S1_Practica2 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI contadorTxt;
    [SerializeField] TextMeshProUGUI contadorTxt2;
    [SerializeField] float velocidad_rotacion = 20f;
    [SerializeField] float velocidad_movimiento = 15f;
    [SerializeField] Transform respawn;
    public int contador1;
    public int contador2;
    // Start is called before the first frame update
    void Start()
    {

        contador1 = 0;
        contador2 = 0;

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
            transform.Translate(transform.right * -1 * velocidad_movimiento * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right * velocidad_movimiento * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = respawn.transform.position;
        }

    }
    private void OnCollisionEnter(Collision other)
    {
        GameObject obj = other.gameObject;
        if (obj.CompareTag("Enemigo"))
        {
            Destroy(obj);
            contador1++;
            contadorTxt.text = " Enemigos derrotados: " + contador1.ToString();
        }

        GameObject obj2 = other.gameObject;
        if (obj2.CompareTag("Moneda"))
        {
            Destroy(obj2);
            contador2=contador2+1;
            contadorTxt2.text = " monedas: " + contador2.ToString();
        }

    }

}
