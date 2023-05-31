using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proyectilBallista : MonoBehaviour
{
    public static int Daño = 1;
    public bool EsDeIzquierda = false;
    public bool EsDeDerecha => !EsDeIzquierda;
    Rigidbody2D rb;
    private MainScript mainScript;

    public string quienSoy;
    GameObject AudioManager;

    audioManager mainAudio;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mainScript = FindObjectOfType<MainScript>();

        AudioManager = GameObject.Find("AudioManager");
        mainAudio = AudioManager.GetComponent<audioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(quienSoy);
    }

     private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == "CapsuleIzquierda") {
            Destroy(this.gameObject);
            mainAudio.impactaBallista (); //Sonido
            mainAudio.GritaM3 (); //Sonido Grito
        }

        if (collision.gameObject.name == "CapsuleDerecha") {
            Destroy(this.gameObject);
            mainAudio.impactaBallista (); //Sonido
            mainAudio.GritaH3 (); //Sonido Grito
        }

        if(quienSoy == "puntoDisparo1" && collision.gameObject.name == "CapsuleDerecha"){
            mainScript.Vida_Capsule_Derecha -= Daño;
        }

        if(quienSoy == "puntoDisparo2" && collision.gameObject.name == "CapsuleIzquierda"){
            mainScript.Vida_Capsule_Izquierda -= Daño;
        }

/*
        MainMovimiento personaje = collision.collider.gameObject.GetComponent<MainMovimiento>();
        // Si se ha chocado con un personaje, le quitamos vida y eso
        if (personaje != null)
        {
            // Si el personaje al que se golpea es de la izquierda
            if (personaje.EsDeIzquierda)
            {
                Debug.Log("Hit personaje de izquierda");
                // Hacerle daño de la flecha
                mainScript.Vida_Capsule_Izquierda -= Daño;

                // Si la flecha es de la derecha, se le suman puntos
                // a la torre derecha
                if (EsDeDerecha)
                {
                    mainScript.Puntos_Derecha++;
                }
                // Si la flecha es de la izquierda, se le restan puntos
                // a la torre izquierda
                else if (EsDeIzquierda)
                {
                    Debug.Log("Autogolpe izquierda");
                    mainScript.Puntos_Izquierda--;
                }
            }
            // Si el personaje al que se golpea es de la derecha
            else if (personaje.EsDeDerecha)
            {
                // Hacerle daño de la flecha
                mainScript.Vida_Capsule_Derecha -= Daño;

                // Si la flecha es de la derecha, se le restan puntos
                // a la torre derecha
                if (EsDeDerecha)
                {
                    Debug.Log("Autogolpe derecha");
                    mainScript.Puntos_Derecha--;
                }
                // Si la flecha es de la izquierda, se le suman puntos
                // a la torre izquierda
                else if (EsDeIzquierda)
                {
                    Debug.Log("Hit!");
                    mainScript.Puntos_Izquierda++;
                }
            }

        }
        */
        rb.isKinematic = true;
        float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        rb.velocity = Vector2.zero;
        rb.angularVelocity = 0f;
        Destroy(rb);
        Destroy(GetComponentInChildren<Collider2D>());
        
    }
}