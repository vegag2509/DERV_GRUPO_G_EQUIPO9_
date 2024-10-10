using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerConrutina : MonoBehaviour
{

    Transform spawn;

    private void Awake()
    {
        spawn = GameObject.Find("SpawnEnemigos").transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine("ConrutinaEnter");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StopCoroutine("CorutinaEnter");
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CorrutinaEnter()
    {
        while (true)
        {
            GameObject.Find("enemigo").transform.position = spawn.position;
            yield return new WaitForSecondsRealtime(3f);
        }
    }
}
