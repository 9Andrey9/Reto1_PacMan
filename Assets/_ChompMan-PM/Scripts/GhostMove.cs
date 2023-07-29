using UnityEngine;
using UnityEngine.AI;

public class GhostMove : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public Transform target;
    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        // No es necesario establecer el objetivo aquí, ya que lo estableceremos en cada frame en Update.
    }

    private void Update()
    {
        // Actualiza la posición del objetivo en cada frame.
        if (target != null)
            SetTarget(target.position);

        // Si el NavMeshAgent ha terminado de calcular el camino.
        if (!agent.pathPending && agent.remainingDistance <= agent.stoppingDistance)
        {
            // Si ya llegó al destino, seleccionamos un nuevo objetivo (que podría ser el mismo).
            // En este caso, el objetivo es la posición actual del jugador (o el punto que estés siguiendo).
            if (target != null)
                SetTarget(target.position);
        }
    }

    private void SetTarget(Vector3 position)
    {
        // Método para establecer el objetivo y calcular el camino.
        agent.SetDestination(position);
    }
}
