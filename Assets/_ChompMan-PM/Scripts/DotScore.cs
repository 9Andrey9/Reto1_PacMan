using UnityEngine;

public class DotScore : MonoBehaviour
{
    public int puntosGanados = 1;
    public GameObject particleEffectPrefab; 
    private ScoreManager scoreManager;
    public AudioSource audioDotCollision;

    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (particleEffectPrefab != null)
            {
                GameObject particleEffectInstance = Instantiate(particleEffectPrefab, transform.position, Quaternion.identity);
                Destroy(particleEffectInstance, 2f); 
                audioDotCollision.Play();
            }

            Destroy(gameObject);
            scoreManager.SumarPuntos(puntosGanados); 
        }
    }
}
