using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMovimiento : MonoBehaviour
{
    //public GameObject gestorSonido;

    //public GameObject Capsule1;
    //public GameObject Capsule2;

    GameObject mainObject;
    
    MainScript mainScript;
    
     void Awake(){
        DontDestroyOnLoad(gameObject); ///ESTO ES PARA QUE NO SE DESTRUYA (video23 GUI Moises)
    }

    // Start is called before the first frame update
    void Start()
    {
        mainObject = GameObject.Find("MainObject");
        mainScript = mainObject.GetComponent<MainScript>();
    }

    // Update is called once per frame
    void Update()
    {
         if (MainScript.Ronda != 0) {
            
        
            //Debug.Log (gameObject.name);

            //Movimiento de Capsule 1 hacia Capsule 2
            if (MainScript.Besito != true && gameObject.name == "Capsule1") {
                //Debug.Log( "avan1" );
                //Movimiento de la Capsule1
                transform.Translate(-1/400f,0,0);
                
            } else if (MainScript.Besito == true && gameObject.name == "Capsule1") {
                transform.Translate(-1/400f,0,0);
            }

            //Movimiento de Capsule 2 hacia Capsule 1
            if (MainScript.Besito != true && gameObject.name == "Capsule2") {
                //Debug.Log( "avan2" );
                //Movimiento de la Capsule2
                transform.Translate(1/400f,0,0) ;
            } else if (MainScript.Besito == true && gameObject.name == "Capsule2") {
                transform.Translate(1/400f,0,0);
            }
        }//Cuando las Rondas llegan a 0 Se apagó el juego

    }

    //Comprobación de contacto físico entre Capsules
    void OnCollisionEnter2D(Collision2D otroObjeto) {
        if ( otroObjeto.gameObject.name == "Capsule2" ) {//|| otroObjeto.gameObject.name == "Capsule1" ) {
            MainScript.Besito = true;
            Debug.Log( "Nos hemos Besado <3" ); 
/*
            //Sonido beso
            gestorSonido.GetComponent<audioManager>().sonidoBesito();
            //gestorSonido.GetComponent<AudioSource>().PlayOneShot(gestorSonido.GetComponent<audioManager>().sonidoBeso, 1f);
*/

            MainScript.Ronda --;
            Debug.Log( "Cambio de Ronda" );

            mainScript.IniciaPosiciones();
        } 

    } //Colision Capsules

//Intento de hacer que reaparezcan las Capsules cuando llegan a un sito concreto fuera de cámara
    void OnTriggerEnter (Collider otroObjeto) {
        if ( otroObjeto.gameObject.name == "Capsule1"){
        mainScript.IniciaPosicion1();
    }
    
    void OnTriggerEnter (Collider otroObjeto) {
        if (otroObjeto.gameObject.name == "Capsule2") {
        mainScript.IniciaPosicion2();
        }
    }
        
   

/*
    void OnTriggerEnter (Collider otroObjeto) {
        if ( otroObjeto.gameObject.name == "Capsule1"){
        transform.position = new Vector2(21,-6.1f);
        } else if (otroObjeto.gameObject.name == "Capsule2") {
        transform.position = new Vector2(-21,-6.1f);
        }
    }
*/
    }
}
