using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S8_ContadorTiempoConRutina : MonoBehaviour
{

    int contadorSegundos;
    [SerializeField] TextMeshProUGUI Texto_Tiempo;

    // Start is called before the first frame update
    void Start()
    {
        contadorSegundos = 0;
        StartCoroutine("corrutinaTiempo");
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    IEnumerator corrutinaTiempo()
    {
        while (true)
        {
            Texto_Tiempo.text = contadorSegundos++.ToString();
            yield return new WaitForSeconds(0.25f);
        }
    }
}
