using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S9_TiempoFuera : MonoBehaviour
{
    int contadorSegundos;
    [SerializeField] TextMeshProUGUI Texto_Tiempo;
    [SerializeField] SceneChange auxiliar;
    [SerializeField] S6_DestroyOnDetec puntuacion;

    // Start is called before the first frame update
    void Start()
    {
        contadorSegundos = 10;
        StartCoroutine("corrutinaTiempo");
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator corrutinaTiempo()
    {
        while (contadorSegundos >= 0)
        {
            Texto_Tiempo.text = contadorSegundos--.ToString();
            yield return new WaitForSeconds(0.25f);
        }
        Debug.Log("El juego ha terminado");
        int score = puntuacion.contador;
        auxiliar.cambioDeEscena(2, score);
    }
}