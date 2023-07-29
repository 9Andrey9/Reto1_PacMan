using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Podio : MonoBehaviour
{

    public TMP_Text podio1;
    public TMP_Text podio2;
    public TMP_Text podio3;
    
    // Start is called before the first frame update
    void Start()
    {
        podio1.text = "camilo";
        podio2.text = "edgar";
        podio3.text = "maria";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
