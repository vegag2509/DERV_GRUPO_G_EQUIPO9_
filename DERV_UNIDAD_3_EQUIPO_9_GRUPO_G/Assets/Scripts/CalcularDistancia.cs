using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalcularDistancia : MonoBehaviour
{

    Transform ubi_objeto;
    float distancia;
    CalcularDistancia auxComponenteDistance;

    public float getdistancia()
    {
        return distancia;

    }

    private void Awake()
    {
        ubi_objeto = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Start is called before the first frame update
    void Start()
    {
        auxComponenteDistance = GetComponent<CalcularDistancia>();

    }

    // Update is called once per frame
    void Update()
    {
        float distanciaEnemigo = auxComponenteDistance.getdistancia();
        if (distanciaEnemigo < 4.0f)
        {
            distancia = Vector3.Distance(transform.position, ubi_objeto.position);
        }
    }
}
