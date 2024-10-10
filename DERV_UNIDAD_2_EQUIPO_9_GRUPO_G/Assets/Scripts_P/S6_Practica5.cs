using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S6_Practica5 : MonoBehaviour
{
    [SerializeField] Transform SpawnEnemigo;
    public GameObject enemigo;

    public void Awake()
    {
        enemigo = GameObject.Find("Enemigo");
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            enemigo.transform.position = SpawnEnemigo.position;
        }
    }

}
