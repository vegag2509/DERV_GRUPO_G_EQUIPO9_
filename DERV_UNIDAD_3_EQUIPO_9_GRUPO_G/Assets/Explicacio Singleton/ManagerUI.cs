using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ManagerUI : MonoBehaviour
{

    TextMeshProUGUI [] contador;
    float tiempoTranscurrido;
    float conSegundos;

    private void Awake()
    {
        contador = GetComponentsInChildren<TextMeshProUGUI>();

    }

    // Start is called before the first frame update
    void Start()
    {

        conSegundos = 0;
        tiempoTranscurrido = 0;

    }

    // Update is called once per frame
    void Update()
    {
        tiempoTranscurrido = Time.deltaTime;
        if (tiempoTranscurrido >= 1f)
        {
            conSegundos++;
            tiempoTranscurrido = 0;
            contador[1].text = conSegundos.ToString();

        }
    }
}
