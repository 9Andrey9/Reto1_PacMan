using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;



public class RegistroUsuarios : MonoBehaviour
{
    public InputField name;
    public InputField lastname;
    public InputField correo;
    
    private string nombre;
    private string apellido;
    private string email;

    //public Text idUsuario;
    public string id;
    public string idUsuario;

    // Start is called before the first frame update

    


    void Start()
    {   nombre =" ";
        apellido = " "; 
        email = " ";

        //idUsuario.text = id;


        if(nombre!=" " && apellido!= " " && email!= " ")
        {
            //StartCoroutine(Upload());
        }

        
        
    
        
    }
    

    // Update is called once per frame
    void Update()
    {
        //idUsuario.text = "Id: " + id;
    }

    
    /*IEnumerator Upload() 
    {
        //nombre = "andrey";
        //apellido  = "peñap"; 
        //email = "peñap@gmail.com";

        WWWForm validacion = new WWWForm();
        validacion.AddField("email", email);
        
        
        UnityWebRequest validar = UnityWebRequest.Post("https://geoapps.esri.co/APIRESTGame/validar-usuario", validacion);

        yield return validar.Send(); 
        if(validar.isNetworkError) 
        {
            Debug.Log(validar.error);
        } 
        else 
        {
            var text = validar.downloadHandler.text;
            respuesta res = JsonUtility.FromJson<respuesta>(text);

            Debug.Log(validar.downloadHandler.text);
            
            Debug.Log(res.message);


            if((res.message).Equals("Usuario no encontrado")){
                WWWForm registro = new WWWForm();
                registro.AddField("name", nombre);
                registro.AddField("apellido", apellido);
                registro.AddField("email", email);
                UnityWebRequest registrar = UnityWebRequest.Post("https://geoapps.esri.co//APIRESTGame/add-usuario", registro);
                yield return registrar.Send();
                if(registrar.isNetworkError) 
                {
                    Debug.Log(registrar.error);
                } 
                else 
                {
                    Debug.Log(registrar.downloadHandler.text);
                }
            }
                
            WWWForm consulta = new WWWForm();
            consulta.AddField("email", email);
            UnityWebRequest consultar = UnityWebRequest.Post("https://geoapps.esri.co/APIRESTGame/consultar-usuario-id", consulta);
            yield return consultar.Send();
            if(consultar.isNetworkError) 
            {
              Debug.Log(consultar.error);
            } 
            else 
            {
                Debug.Log("User encontrado");
                Debug.Log(consultar.downloadHandler.text);
                var datos = consultar.downloadHandler.text;
                Usuario datosjson = JsonUtility.FromJson<Usuario>(datos);
                id = datosjson.id;
                Debug.Log(id);

                /*Debug.Log("Llegu al podio");

                UnityWebRequest userupd = UnityWebRequest.Put("https://geoapps.esri.co/APIRESTGame/upd-usuario/"+id, "{\"score1\":\""+30+"\"}");

                Debug.Log(id);

                userupd.SetRequestHeader ("Content-Type", "application/json");

                yield return userupd.Send();

                if(userupd.isNetworkError) {

                Debug.Log(userupd.error);

                }

                else {

                Debug.Log("Upload complete!");
                }



            }
            
        }
    }

    private void OnDestroy()
	{
		SaveData();
	}

	private void SaveData()
	{
		PlayerPrefs.SetString(puntosPrefsName, id);
		Debug.Log("Se guardo la info");
	
	}

	private void LoadData()
	{
		id = PlayerPrefs.GetString(puntosPrefsName, id);
		Debug.Log("Se leyo la info");
	}*/



    public void Saludar()
    {
        Debug.Log("Hola, llegue");
    }

                    


    public void Correr()
    {
       // StartCoroutine(Upload());
        SceneManager.LoadScene(1);
    }

    public void ReadNombre(string s)
    {
        nombre = s;
        Debug.Log(nombre);
    }

    public void ReadApellido(string s)
    {
        apellido = s;
        Debug.Log(apellido);
    }

    public void ReadEmail(string s)
    {
        email = s;
        Debug.Log(email);
    }

    


}

/*[System.Serializable]
    public class respuesta
    {
        public bool error ;
        public string message ;
    }
[System.Serializable]
    public class Usuario
    {
        public string id;
        public string name;
        public bool error ;
        public string message ;
    }*/