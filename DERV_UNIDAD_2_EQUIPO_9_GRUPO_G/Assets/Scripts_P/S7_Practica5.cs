using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class S7_Practica5 : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        GameObject obj = other.gameObject;
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(obj);
        }

    }


}
