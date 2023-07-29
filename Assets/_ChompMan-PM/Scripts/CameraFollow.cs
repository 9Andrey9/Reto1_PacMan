using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // El transform del objeto que queremos seguir (el jugador/Pac-Man en este caso)
    public Vector3 offset; // Offset para controlar la distancia entre el jugador y la cámara

    void LateUpdate()
    {
        if (target == null) return; // Si el objetivo no está asignado, no hacemos nada

        // Obtener la nueva posición de la cámara siguiendo al jugador con el offset
        Vector3 targetPosition = target.position + offset;

        // Actualizar la posición de la cámara para seguir al jugador sin cambios de rotación
        transform.position = targetPosition;
    }
}
