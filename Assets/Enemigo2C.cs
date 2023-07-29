using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo2C : MonoBehaviour
{
     public Animator ani;
    public float rangoDeAlerta;
    public LayerMask capaDelJugador;
    public Transform jugador;
    public float velocidad;
    bool estarAlerta;

   
    void Start()
    {
        ani = GetComponent<Animator>();
        ani.SetBool("walk", false);
    }
    
    

    // Update is called once per frame
    void Update()
    {
        estarAlerta = Physics.CheckSphere(transform.position, rangoDeAlerta, capaDelJugador);
        ani.SetBool("walk", true);
        if(estarAlerta == true)
        {
           
           // transform.LookAt(jugador);
           Vector3 posJugador = new Vector3(jugador.position.x, transform.position.y, jugador.position.z);
           transform.LookAt(posJugador);
           transform.position = Vector3.MoveTowards(transform.position, posJugador, velocidad * Time.deltaTime);
           
           ani.SetBool("run", true);
           
        }else{
            ani.SetBool("run", false);
            
        }
    }
    
    
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, rangoDeAlerta);
    }

    
}
