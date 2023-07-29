using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntraTrigger1 : MonoBehaviour
{
    public AudioSource audio;


    private void OnTriggerEnter(Collider other)
    {
        if((other.tag == "personaje"))
        {
            audio.Play();
        }
        
    }

    //

    private void OnTriggerExit(Collider other)
    {
        if((other.tag == "personaje"))
        {
            audio.Stop();
        }
    }

}
