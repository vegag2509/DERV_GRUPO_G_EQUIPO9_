using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiodeEscena : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int escenaActiva = SceneManager.GetActiveScene().buildIndex;
        switch (escenaActiva)
        {
            case 0:
                if (Input.GetKeyDown(KeyCode.C))
                {
                    escenaActiva++;
                    SceneManager.LoadScene(escenaActiva);
                }
                break;
            case 1:
                if (Input.GetKeyDown(KeyCode.C))
                {
                    escenaActiva++;
                    SceneManager.LoadScene(escenaActiva);
                }
                break;
            case 2:
                if (Input.GetKeyDown(KeyCode.C))
                {
                    escenaActiva++;
                    SceneManager.LoadScene(escenaActiva);
                }
                break;
            case 3:
                if (Input.GetKeyDown(KeyCode.C))
                {
                    escenaActiva++;
                    SceneManager.LoadScene(escenaActiva);
                }
                break;
            case 4:
                if (Input.GetKeyDown(KeyCode.C))
                {
                    escenaActiva = 0;
                    SceneManager.LoadScene(escenaActiva);
                }
                break;

        }
    }

}
