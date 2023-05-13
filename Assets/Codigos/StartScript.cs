using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EntrarJuego(){
        SceneManager.LoadScene("Main_Nivel");
    }
    public void EleccionPersonajes(){
    SceneManager.LoadScene("Eleccion_Personajes");
    }

    public void Tutorial(){
    SceneManager.LoadScene("Tutorial");
    }
}
