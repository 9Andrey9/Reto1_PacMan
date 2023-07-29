using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int puntosParaInstanciarPrefab = 18;
    public GameObject cerezaPrefab;

    private int puntos = 0;


    public void SumarPuntos(int cantidadPuntos)
    {
        puntos += cantidadPuntos;
        scoreText.text = puntos.ToString();

        if (puntos >= puntosParaInstanciarPrefab)
        {
            cerezaPrefab.SetActive(true);
        }
    }


}
