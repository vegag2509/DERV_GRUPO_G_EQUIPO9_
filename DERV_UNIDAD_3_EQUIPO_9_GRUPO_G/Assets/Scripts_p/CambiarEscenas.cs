
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscenas : MonoBehaviour
{
    int index_escena;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        index_escena = SceneManager.GetActiveScene().buildIndex;
        if (Input.GetKeyDown(KeyCode.Space)) {
            index_escena++;
            index_escena %= 3;
            cambioEscena(index_escena);
        }
    }
    public void cambioEscena(int index)
    {
        SceneManager.LoadScene(index);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            index_escena++;
            index_escena %= 3;
            cambioEscena(index_escena);
        }
    }

}
