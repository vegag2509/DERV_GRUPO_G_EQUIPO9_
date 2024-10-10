using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CambioEscena : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int escena_actual = SceneManager.GetActiveScene().buildIndex;

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (escena_actual == 0)
            {
                cambioEscena(1);

            }else if(escena_actual == 1)
            {
                cambioEscena(2);
            }else if (escena_actual == 2)
            {
                cambioEscena(0);

            }
        }
    }

    public void cambioEscena(int index_escena)
    {
        SceneManager.LoadScene(index_escena);
    }
}
