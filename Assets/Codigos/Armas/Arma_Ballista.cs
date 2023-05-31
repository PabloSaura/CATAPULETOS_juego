using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma_Ballista : MonoBehaviour


{
    public Transform puntoA;
    public Transform puntoB;
    public GameObject virotePrefab;
    public float velocidadGiro = 27f;
    public float fuerzaDisparo = 10f;

    private Transform objetivo;
    private bool disparando = false;
    public float distanciaDestruccion = 27f; ///para que se destruyaaa


    GameObject AudioManager;

    audioManager mainAudio;

    bool lanzaBallista = false;
    bool puedoLanzar = true;


    private void Start()
    {
        objetivo = puntoA;

        AudioManager = GameObject.Find("AudioManager");
        mainAudio = AudioManager.GetComponent<audioManager>();
    }

    private void Update()
    {
        RotarBallesta();

        if (Input.GetKeyDown(KeyCode.Return) && !disparando && puedoLanzar == true && gameObject.name == "puntoDisparo2")
        {
            DispararVirote();
            //Destroy(virotePrefab);
            
            mainAudio.disparaBallista (); //Sonido

            puedoLanzar = false;
            StartCoroutine(esperaBallista());
            //corutine de 1.5f segundos
        }

        //CONTROL para Bando_Derecha
        if (Input.GetKeyDown(KeyCode.LeftControl) && !disparando && puedoLanzar == true && gameObject.name == "puntoDisparo1")
        {
            DispararVirote();
            //Destroy(virotePrefab);

            
            mainAudio.disparaBallista (); //Sonido

            puedoLanzar = false;
            StartCoroutine(esperaBallista());
            //corutine de 1.5f segundos
        }
        
    }

    private void RotarBallesta() ///El método RotarBallesta() utiliza Mathf.LerpAngle para interpolar suavemente el ángulo en el eje Z entre el ángulo de puntoA y puntoB, utilizando Mathf.PingPong para que el ángulo oscile automáticamente de un punto a otro.
    {
        Vector3 direccion = objetivo.position - transform.position;
        float anguloZ = Mathf.Atan2(direccion.y, direccion.x) * Mathf.Rad2Deg; ///Mathf.Atan2 para calcular el ángulo en el eje Z basado en la dirección hacia el objetivo
        Quaternion rotacion = Quaternion.Euler(0f, 0f, anguloZ); ///EUKER usar para representar la orientación o rotación de un objeto
        transform.rotation = Quaternion.Slerp(transform.rotation, rotacion, Time.deltaTime * velocidadGiro); ///SLERP Interpola entre dos orientaciones mediante la interpolación lineal esférica.

        objetivo = (objetivo == puntoA) ? puntoB : puntoA;
    }

    private void DispararVirote()
    {
        disparando = true;

        GameObject virote = Instantiate(virotePrefab, transform.position, transform.rotation);
        Rigidbody2D rb = virote.GetComponent<Rigidbody2D>();
        virote.GetComponent<proyectilBallista>().quienSoy = gameObject.name;

        Vector2 direccionDisparo = transform.right;
        rb.AddForce(direccionDisparo * fuerzaDisparo, ForceMode2D.Impulse);

        disparando = false;
    }

     IEnumerator esperaBallista()
    {
        yield return new WaitForSeconds(1.5f);
        puedoLanzar = true;
        Debug.Log("puedo lanzar Ballista");
    }

    /*
    void OnGUI () {
        Event eventoTecla = Event.current;
        Debug.Log ("La tecla presionada:" + eventoTecla.keyCode);
    }
    */
}





/*
{
    //Armas
    //public GameObject Ballista1;
    /////public GameObject Ballista2;

    //Proyectil y Velocidad
    /////public GameObject virote;
    /////public float velocidadVirote = 3.0f; 
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /////if(Input.GetKeyDown(KeyCode.Backspace) == true) {
            /////Debug.Log("Pulsé [Backspace]");
            /////Input.GetAxis("Horizontal");
            /////Input.GetAxis("Vertical");
        }
}
*/
