using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rondas : MonoBehaviour
{
    
   // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

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
     void OnCollisionEnter2D(Collision2D otroObjeto){
        if (MainScript.Besito == true) {
            MainScript.Ronda --;
            Debug.Log( "Cambio de Ronda" );
        }
    }
    
    
}
