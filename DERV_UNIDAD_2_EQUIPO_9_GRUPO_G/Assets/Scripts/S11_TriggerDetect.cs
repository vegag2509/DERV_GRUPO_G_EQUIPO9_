using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class S11_TriggerDetect : MonoBehaviour
{

    private void OntriggerEnter(Collider other)
    {
        Debug.Log("T. enter " + other.gameObject.name);

    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("T. exit" + other.gameObject.name);
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("T. stay" + other.gameObject.name);
    }



}
