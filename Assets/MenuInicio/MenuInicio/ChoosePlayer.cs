using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoosePlayer : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void ElegirEllen()
    {
        SceneManager.LoadScene("Cinematica1Ellen");

    }

    public void ElegirExo()
    {
        SceneManager.LoadScene("Cinematica1Exo");

    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
