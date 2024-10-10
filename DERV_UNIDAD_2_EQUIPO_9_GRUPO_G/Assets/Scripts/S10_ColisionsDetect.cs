using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S10_ColisionsDetect : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("enter" + other.gameObject.name);
    }

    private void OnCollisionExit(Collision other)
    {
        Debug.Log("exit" + other.gameObject.name);
    }

    private void OnCollisionStay(Collision other)
    {
        Debug.Log("stay" + other.gameObject.name);
    }

}
