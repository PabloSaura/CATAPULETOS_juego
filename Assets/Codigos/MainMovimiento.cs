using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMovimiento : MonoBehaviour
{
    //public GameObject gestorSonido;

    public bool EsDeIzquierda = false;
    public bool EsDeDerecha => !EsDeIzquierda;

    GameObject mainObject;

    MainScript mainScript;

    void Start()
    {
        mainObject = GameObject.Find("MainObject");
        mainScript = mainObject.GetComponent<MainScript>();
    }

    // Update is called once per frame
    void Update()
    {
        // Si es la última ronda, no se hace nada
        if (MainScript.Ronda <= 0) return;

        //Debug.Log(MainScript.Besito);
        transform.Translate(MainScript.velocidadCapsulas * Time.deltaTime * (EsDeIzquierda ? 1 : -1), 0, 0);

        //Movimiento de Capsule 1 hacia Capsule 2
        //if (MainScript.Besito == false && gameObject.name.Contains("Capsule"))
        //{
        //    //Movimiento de la Capsule1
        //}
    }

    //Comprobación de contacto físico entre Capsules
    void OnCollisionEnter2D(Collision2D otroObjeto)
    {
        if (otroObjeto.gameObject.name.ToLower().Contains("capsuleizquierda"))
        {
            MainScript.Besito = true;
            /*
                        //Sonido beso
                        gestorSonido.GetComponent<audioManager>().sonidoBesito();
                        //gestorSonido.GetComponent<AudioSource>().PlayOneShot(gestorSonido.GetComponent<audioManager>().sonidoBeso, 1f);
            */

            MainScript.Ronda--;
            Debug.Log("Cambio de Ronda a: " + MainScript.Ronda);

            //mainScript.IniciaPosiciones();
        }

    } //Colision Capsules

    //Intento de hacer que reaparezcan las Capsules cuando llegan a un sito concreto fuera de cámara
    /*
        void OnTriggerEnter (Collider otroObjeto) {
            if ( otroObjeto.gameObject.name == "Capsule1"){
            //mainScript.IniciaPosicion1();
        }
        */
    /*
        void OnTriggerEnter (Collider otroObjeto) {
            if (otroObjeto.gameObject.name == "Capsule2") {
            mainScript.IniciaPosicion2();
            }
    */
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


