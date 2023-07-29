using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArbolMuerto : MonoBehaviour
{
    public GameObject Hojas;
    public GameObject Efecto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemigo")
        {
            Hojas.SetActive(false);
            Efecto.SetActive(true);
        }
    }
}
