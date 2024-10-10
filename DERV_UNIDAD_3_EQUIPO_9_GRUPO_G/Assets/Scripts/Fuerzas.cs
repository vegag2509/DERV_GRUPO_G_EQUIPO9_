using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuerzas : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float velocidadFuerza;
    float tiempoPantalla = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.AddForce(transform.right * velocidadFuerza, ForceMode.Impulse);
        //rb.AddForce(transform.right * velocidadFuerza, ForceMode.VelocityChange);
        //rb.AddForce(transform.right * velocidadFuerza, ForceMode.Force); 
        //rb.AddForce(transform.right * velocidadFuerza, ForceMode.Acceleration); //considera la masa



    }

    private void Update()
    {
        tiempoPantalla += Time.deltaTime;
        if (tiempoPantalla > 1.5f)
        {
            tiempoPantalla = 0;
            gameObject.SetActive(false);
        }
    }

    void FixedUpdate()
    {
        //rb.AddForce(transform.right * velocidadFuerza * Time.fixedDeltaTime, ForceMode.Impulse);
        rb.AddForce(velocidadFuerza * Time.fixedDeltaTime * transform.forward, ForceMode.Impulse);

    }

}
