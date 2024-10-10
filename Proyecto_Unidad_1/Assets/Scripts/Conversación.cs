using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class Conversación : MonoBehaviour
{
    [System.Serializable]
    public struct Dialogo
    {
        public string nombre;
        public string texto;
        public Sprite imagen;
    }

    public List<Dialogo> dialogos;
    [SerializeField] TextMeshProUGUI txt_nombre;
    [SerializeField] TextMeshProUGUI txt_texto;
    [SerializeField] Image personaje;

    int contador;
    // Start is called before the first frame update
    void Start()
    {
        contador = 0;
        mostrarDialogo();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            contador++;
            contador %= dialogos.Count;
            mostrarDialogo();
        }
    }

    void mostrarDialogo()
    {
        txt_nombre.text = dialogos[contador].nombre;
        txt_texto.text = dialogos[contador].texto;
        personaje.sprite = dialogos[contador].imagen;

    }

}
