using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerPodio : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Podio(string enlace)
    {
        Application.OpenURL(enlace);
    }

}
