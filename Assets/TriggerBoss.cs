using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBoss : MonoBehaviour
{
    public GameObject Jaula;
    public GameObject JaulaConBoss;
    public GameObject Boss;
    public GameObject Caos;
    public GameObject sol;
    public GameObject sol1;
    public GameObject TimerFinal;
    public GameObject TextJaulaAni;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Cautiverio")
        {
            
            TextJaulaAni.SetActive(false);
            Caos.SetActive(false);
            Boss.SetActive(false);
            Jaula.SetActive(false);
            JaulaConBoss.SetActive(true);
            sol.SetActive(false);
            sol1.SetActive(true);
            TimerFinal.SetActive(true);
        }
            
            
    }
}
