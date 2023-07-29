using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlane : MonoBehaviour
{
    public GameObject chomper;
    public GameObject granadier;

    
    
    private void OnTriggerEnter(Collider other)
    {
        if((other.tag == "personaje"))
        {
            chomper.SetActive(false);
            granadier.SetActive(false);
        }
        
    }

    //

    private void OnTriggerExit(Collider other)
    {
        if((other.tag == "personaje"))
        {
            chomper.SetActive(true);
            granadier.SetActive(true);
        }
    }

}
