using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private string enemyTag = "Fantasma"; 
    public GameObject gameOver;
    public GameObject gameWin;
    public AudioSource audioGameOver;
    public AudioSource audioGameWin;
    public AudioSource audioAmbiente;

    private void OnCollisionEnter(Collision collision)
    {
    
        if (collision.gameObject.CompareTag(enemyTag))
        {
        
            gameObject.SetActive(false);
            gameOver.SetActive(true);
            audioGameOver.Play();

        
        }

        if (collision.gameObject.CompareTag("Finish"))
        {
        
            gameObject.SetActive(false);
            gameWin.SetActive(true);
            audioAmbiente.Stop();
            audioGameWin.Play();

        
        }
    }
}
