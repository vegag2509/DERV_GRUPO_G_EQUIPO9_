using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager_UI : MonoBehaviour
{
    private Manager_UI instance;

    [SerializeField] GameObject usuario;

    TextMeshProUGUI nombre_usuario;

    string Nusu;
    int indexEscena = 0;
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        indexEscena = SceneManager.GetActiveScene().buildIndex;
        if(indexEscena != 0)
        {
            Nusu = PlayerPrefs.GetString("usu", "");
            
        }
        Debug.Log("usu" + Nusu);
    }

    public void cambiarEscena(int indexN)
    {
        if (indexEscena == 0)
        {
            nombre_usuario = usuario.GetComponent<TextMeshProUGUI>();
            Nusu = nombre_usuario.text; //almacena el string que ingresó el usuario
            PlayerPrefs.SetString("Nusu", Nusu); //almacena en memoria el nombre del usuario
            indexN++;
        }

        SceneManager.LoadScene(indexN);
        
    }
    
}

