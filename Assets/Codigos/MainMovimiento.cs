using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMovimiento : MonoBehaviour
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

        //Debug.Log (gameObject.name);

        if (MainScript.Besito != true && gameObject.name == "Capsule1") {
            //Debug.Log( "avan1" );
            //Movimiento de la Capsule1
            transform.Translate(-1/300f,0,0);
        }


        if (MainScript.Besito != true && gameObject.name == "Capsule2") {
            //Debug.Log( "avan2" );
            //Movimiento de la Capsule2
            transform.Translate(1/300f,0,0) ;
        }

    }

    //Comprobación de contacto físico entre Capsules
    void OnCollisionEnter2D(Collision2D otroObjeto) {
        if ( otroObjeto.gameObject.name == "Capsule2" ) {//|| otroObjeto.gameObject.name == "Capsule1" ) {
            MainScript.Besito = true;
            Debug.Log( "Nos hemos Besado <3" ); 

            MainScript.Ronda --;
            Debug.Log( "Cambio de Ronda" );

            mainScript.IniciaPosiciones();






        } 
    } 
}
