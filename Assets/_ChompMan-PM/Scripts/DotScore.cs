using UnityEngine;

public class DotScore : MonoBehaviour
{
    public int puntosGanados = 1;
    public GameObject particleEffect; 
    private ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           
            if (particleEffect != null)
            {
                Instantiate(particleEffect, transform.position, Quaternion.identity);
            }

            Destroy(gameObject);
            scoreManager.SumarPuntos(puntosGanados);
        }
    }
}

