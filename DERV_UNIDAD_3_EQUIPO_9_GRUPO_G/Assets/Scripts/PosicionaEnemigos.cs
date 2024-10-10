using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicionaEnemigos : MonoBehaviour
{

    [SerializeField] Transform ubispawn;
    public GameObject enemigo;

    private void Awake()
    {
        enemigo = GameObject.Find("Enemigo");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")){
            enemigo.transform.position = ubispawn.position;
        }
    }

}
