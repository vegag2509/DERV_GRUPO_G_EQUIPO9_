using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAt : MonoBehaviour
{

    Transform ubi_objeto;
    CalcularDistancia cd;


    private void Awake()
    {
        ubi_objeto = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Start is called before the first frame update
    void Start()
    {
        cd = GetComponent<CalcularDistancia>();
    }

    // Update is called once per frame
    void Update()
    {
        float distanciaEnemigo = cd.getdistancia();
        if(distanciaEnemigo < 10.0f)
        {
            float y = ubi_objeto.position.y;
            if(y > 5.0f)
            {
                transform.LookAt(new Vector3(ubi_objeto.position.x, 2f, ubi_objeto.position.x));
            }
        }

    }
}
