using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S6_DestroyOnDetec : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI contadorTxt;
        public int contador;
    private void OnCollisionEnter(Collision other)
    {
        GameObject obj = other.gameObject;
        if (obj.CompareTag("Enemigo")) {
            Destroy(obj);
            contador++;
            contadorTxt.text = " Enemigos derrotados:  " + contador.ToString();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        contador = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }



}
