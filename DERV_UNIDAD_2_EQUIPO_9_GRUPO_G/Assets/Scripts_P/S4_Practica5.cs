using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class S4_Practica : MonoBehaviour
{
    float aumentoVelocidad = 10f;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            S1_Practica5 player = other.GetComponent<S1_Practica5>();
            if (player != null)
            {
                StartCoroutine(aumentarVelocidad(player));
            }
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            S1_Practica5 player = other.GetComponent<S1_Practica5>();
            if (player != null)
            {
                StartCoroutine(disminuirVelocidad(player));
            }
        }
    }

    private IEnumerator aumentarVelocidad(S1_Practica5 jugador)
    {
        float velocidadOriginal = jugador.velocidadMovimiento += aumentoVelocidad;
        yield return new WaitForSeconds(velocidadOriginal);
    }

    IEnumerator disminuirVelocidad(S1_Practica5 jugador)
    {
        float velocidadOriginal = jugador.velocidadMovimiento -= aumentoVelocidad;
        yield return new WaitForSeconds(velocidadOriginal);
    }

}
