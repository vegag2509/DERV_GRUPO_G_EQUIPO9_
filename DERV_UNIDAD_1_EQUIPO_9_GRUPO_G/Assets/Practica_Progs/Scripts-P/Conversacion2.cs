using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Conversacion2 : MonoBehaviour
{

    [System.Serializable]
    public struct Dialogo
    {
        public string name;
        public string texto;
        public Sprite imagen;
    }

    public List<Dialogo> charla;
    [SerializeField] TextMeshProUGUI txt_mensaje;
    [SerializeField] TextMeshProUGUI txt_nombre;
    [SerializeField] Image foto_personaje;

    int contador;
    void mostrarDialogo()
    {
        txt_mensaje.text = charla[contador].texto;
        txt_nombre.text = charla[contador].name;
        foto_personaje.sprite = charla[contador].imagen;

    }


    // Start is called before the first frame update
    void Start()
    {
        contador = 0;
        mostrarDialogo();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.C))
        {
            contador++;
            contador%=charla.Count;
            Debug.Log(contador);
            mostrarDialogo();
        }
    }
}
