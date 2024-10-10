using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour
{
    [SerializeField] Transform spawn_Enemigos;
    Transform ubi_objeto;
    float distancia;
    Enemigos auxComponenteDistance;
    Movimientocompuesto respawnPlayer;
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
        auxComponenteDistance = GetComponent<Enemigos>();

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

    private void OnCollisionEnter(Collision other)
    {
        GameObject obj = other.gameObject;
        if (other.gameObject.CompareTag("Player"))
        {
            Movimientocompuesto respawnPlayer = other.gameObject.GetComponent<Movimientocompuesto>();
            if (respawnPlayer != null) {
                this.gameObject.transform.position = respawnPlayer.transform.position;
            }
        }
    }

}
