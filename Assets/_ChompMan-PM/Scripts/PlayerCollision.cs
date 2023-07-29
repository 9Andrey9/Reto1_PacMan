using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private string enemyTag = "Fantasma"; 
    public GameObject gameOver;

    private void OnCollisionEnter(Collision collision)
    {
    
        if (collision.gameObject.CompareTag(enemyTag))
        {
        
            gameObject.SetActive(false);
            gameOver.SetActive(true);

        
        }
    }
}
