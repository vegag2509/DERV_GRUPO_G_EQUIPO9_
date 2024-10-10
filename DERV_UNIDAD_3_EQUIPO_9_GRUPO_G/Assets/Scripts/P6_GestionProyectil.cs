using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P6_GestionProyectil : MonoBehaviour
{

    [SerializeField] GameObject proyectil;
    [SerializeField] Transform pos_inicio_proyectil;
    [SerializeField] List<GameObject> proyectiles;
    int proyectilaDespachar;
    // Start is called before the first frame update
    void Start()
    {
        int n = 10; 
        proyectiles = new List<GameObject>();
        GameObject temp;
        for (int i = 0; i < n; i++) 
        {
            temp = Instantiate<GameObject>(proyectil, 
                pos_inicio_proyectil.position,
                pos_inicio_proyectil.rotation);
            temp.SetActive(false);
            proyectiles.Add(temp);
            temp.name = "Proyectil" + 1;
            temp.tag = "Bala"; //se debe asegurar que el tag exista
        }
        proyectilaDespachar = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            proyectiles[proyectilaDespachar].transform.position = pos_inicio_proyectil.position;
            proyectiles[proyectilaDespachar].transform.rotation = pos_inicio_proyectil.rotation;
            proyectiles[proyectilaDespachar].GetComponent<Rigidbody>().velocity = new Vector3 (0, 0, 0);
            proyectiles[proyectilaDespachar].SetActive(true);
            proyectilaDespachar++;
            proyectilaDespachar %= proyectiles.Count;
        }

    }
}
