using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HandleTrampa : MonoBehaviour
{

    float tiempo_en_trigger;
    float tiempo_para_nuevo_enemigo;
    Transform spawn;
    [SerializeField] List<GameObject> listaenemigos;
    int contadorEnemigoActual;


    private void Awake()
    {
        spawn = GameObject.Find("SpawnEnemigos").transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        tiempo_para_nuevo_enemigo = 1.0f;
        contadorEnemigoActual = 0;
    }


    //tarea 23 de septiembre == hacer la versión usando conrutina y enter/exit trigger

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        tiempo_en_trigger += Time.deltaTime;
        if (tiempo_en_trigger > tiempo_para_nuevo_enemigo)
        {

            //gnerar enemigo
            listaenemigos[(contadorEnemigoActual)].transform.position = spawn.position;
            ///
            listaenemigos[contadorEnemigoActual].GetComponent<Rigidbody>().AddForce(25f * -1 * transform.up, ForceMode.Impulse);
            ///
            contadorEnemigoActual++;
            contadorEnemigoActual %= contadorEnemigoActual;

            ////
            tiempo_en_trigger = 0.0f;
        }
    }

}
