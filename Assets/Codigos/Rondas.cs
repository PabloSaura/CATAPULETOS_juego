using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rondas : MonoBehaviour
{
    GameObject mainObject;

    MainScript mainScript;

   // Start is called before the first frame update
    void Start()
    {
        mainObject = GameObject.Find("MainObject");
        mainScript = mainObject.GetComponent<MainScript>();
    }

    // Update is called once per frame
    void Update()
    {

        //Al Cambiar la Ronda, Capsule 1 vuelve a su sitio inicial
        if (MainScript.Besito == true && gameObject.name == "Capsule1") {
            //Debug.Log( "avan1" );
            //Movimiento de la Capsule1
            transform.position = new Vector3(12,-5,10);
        }

        //Al Cambiar la Ronda, Capsule 2 vuelve a su sitio inicial
        if (MainScript.Besito == true && gameObject.name == "Capsule2") {
            //Debug.Log( "avan2" );
            //Movimiento de la Capsule2
            transform.position = new Vector3(-16,-5,10);
        }

        if (MainScript.Ronda == 0) {
            Debug.Log ("Fin de Partida");
        }
    
    }

    //Comprobación de contacto físico entre Capsules
    /*    void OnCollisionEnter2D(Collision2D otroObjeto) {
            if ( otroObjeto.gameObject.name == "Capsule2" || otroObjeto.gameObject.name == "Capsule1" ) {
                MainScript.Besito = true;
                MainScript.Ronda --;
                Debug.Log( "Cambio de Ronda" );
            }
        }
        */
    
    /*
    void OnCollisionEnter2D(Collision2D otroObjeto){
        if (MainScript.Besito == true) {
            MainScript.Ronda --;
            Debug.Log( "Cambio de Ronda" );
        }
    }
    */
    
    
}
