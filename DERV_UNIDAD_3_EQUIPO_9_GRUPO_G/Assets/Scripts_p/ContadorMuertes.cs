using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ContadorMuertes : MonoBehaviour
{
    int contador;
    [SerializeField] TextMeshProUGUI contadorM;

    // Start is called before the first frame update
    void Start()
    {
        contador = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        GameObject obj = other.gameObject;
        if (obj.CompareTag("Enemigo"))
        {
            contador++;
            contadorM.text = "Muertes: "+ contador.ToString();
        }
    }

}
