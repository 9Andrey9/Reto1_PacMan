using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScenes : MonoBehaviour
{
    public string actualScene = "Reto1";
    public string inicioScene = "MenuInicio";

    public void JugardeNuevo()
    {
        SceneManager.LoadScene(actualScene);
    }


    public void VolveraInicio()
    {
        SceneManager.LoadScene(inicioScene);
    }
}
