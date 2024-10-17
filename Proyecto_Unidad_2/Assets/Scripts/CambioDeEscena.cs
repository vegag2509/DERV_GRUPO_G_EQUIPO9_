using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour
{
    
    int EscenaActiva;
    public GameObject enemigo;
    int contadorSegundos;
    [SerializeField] TextMeshProUGUI Texto_Tiempo;
    private void Awake() {
        enemigo = GameObject.Find("Enemigo");
    }

    // Start is called before the first frame update
    void Start()
    {
        contadorSegundos = 5;
        StartCoroutine("corrutinaTiempo");
    }

    // Update is called once per frame
    void Update()
    {        
        EscenaActiva = SceneManager.GetActiveScene().buildIndex;
        if(EscenaActiva==0 || EscenaActiva==3 || EscenaActiva ==4 ){ //si escena activa es 0, que sería la escena de inicio

            if (Input.GetKeyDown(KeyCode.Space)){
                SceneManager.LoadScene(1); //cambia a la escena 1 al presionar la tecla
            }
        }
    }
    private void OnCollisionEnter(Collision other){
        if(other.gameObject.CompareTag("Player")){
            
            SceneManager.LoadScene(3); //escena de muerte
        }
    }

    IEnumerator corrutinaTiempo(){
        while(contadorSegundos >= 0){
            Texto_Tiempo.text = contadorSegundos--.ToString();
            yield return new WaitForSeconds(.5f);
        }
        SceneManager.LoadScene(4); //escena fin del tiempo
    }
}
