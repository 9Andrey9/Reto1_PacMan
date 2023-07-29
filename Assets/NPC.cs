using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    public float speed = 3.0f;
    public Transform target;
    public UnityEngine.AI.NavMeshAgent agente;

    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, speed*Time.deltaTime));
        agente.destination = target.position;

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Point")
        {
            target=other.gameObject.GetComponent<NextPoint>().nextPoint;
            transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
        }
    }
}
