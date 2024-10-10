using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class S5_Practica5 : MonoBehaviour
{

    [SerializeField] Transform Spawn2;
    public GameObject player;

    public void Awake()
    {
        player = GameObject.Find("Player");
    }
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.transform.position = Spawn2.position;
        }
    }


}
