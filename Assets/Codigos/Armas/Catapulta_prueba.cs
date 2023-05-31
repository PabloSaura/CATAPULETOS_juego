using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catapulta_prueba : MonoBehaviour
{
    GameObject AudioManager;

    audioManager mainAudio;


    public bool EsDeIzquierda = true;
    public bool EsDeDerecha => !EsDeIzquierda;
    public GameObject bolaPrefab;
    public float fuerzaLanzamiento = 10f;

    public float variacionX = 27f; //medidas provisionales
    public float distanciaDestruccion = 27f; ///para que se destruyaaa

    bool lanzaBola = false;

    bool puedoLanzar = true;

    private GameObject bolaLanzada;
    public GameObject CapsuleIzquierda;
    public GameObject CapsuleDerecha;

Vector2 fuerza;

    // Start is called before the first frame update
    void Start()
    {
        AudioManager = GameObject.Find("AudioManager");
        mainAudio = AudioManager.GetComponent<audioManager>();
    }

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.RightShift) && puedoLanzar == true && gameObject.name == "puntoDisparo2")
        {
            Debug.Log("lanzar");
            puedoLanzar = false;
            LanzarBola(false);

            mainAudio.disparaCatapulta(); //Sonido

            StartCoroutine(esperaBola());
        }

         //CONTROL para Bando_Derecha
        if (Input.GetKeyDown(KeyCode.Space) && puedoLanzar == true && gameObject.name == "puntoDisparo1")
        {
            Debug.Log("lanzar");
            puedoLanzar = false;
            LanzarBola(true);

            mainAudio.disparaCatapulta(); //Sonido

            StartCoroutine(esperaBola());
        }


        if (bolaLanzada != null && Vector2.Distance(transform.position, bolaLanzada.transform.position) >= distanciaDestruccion) // NULL: para indicar un valor no definido o desconocido (volver a ver el tuto)
        {
            Destroy(bolaLanzada);
            bolaLanzada = null; ///null: para indicar un valor no definido o desconocido (mirar tutotial de nuevo)
        }
    }
    
    private void LanzarBola(bool lanzaDerecha)
    {
        if (bolaLanzada)
        {
            lanzaBola = true;
            Debug.Log(lanzaBola);
        }
        /*    
            void OnCollisionEnter(Collision collision) ///ESTO ES PARA DESTRUIR LA BOLA AL TOCAR A LOS PERSONAJES
        {
            if (collision.gameObject.name == "CapsuleDerecha")
            {
                Destroy(this.gameObject);
            }
            if (collision.gameObject.name == "CapsuleIzquierda")
            {
                Destroy(this.gameObject);
            }
        */
        bolaLanzada = Instantiate(bolaPrefab, transform.position, Quaternion.identity);
        bolaLanzada.GetComponent<Proyectil_Catapulta>().EsDeIzquierda = EsDeIzquierda;
        Rigidbody2D rb = bolaLanzada.GetComponent<Rigidbody2D>();

        

        // Aplica una fuerza en la dirección hacia la derecha con una variación en el eje X
        
        if(lanzaDerecha){
            fuerza = new Vector2(fuerzaLanzamiento + Random.Range(variacionX-10, variacionX+10)*-1, 100f); /// EL 27f ES LA FUERZA EN "Y" PARA QUE VAYA BOMBEADITA
        }else{
            fuerza = new Vector2(fuerzaLanzamiento + Random.Range(variacionX-10, variacionX+10), 100f); /// EL 27f ES LA FUERZA EN "Y" PARA QUE VAYA BOMBEADITA
        }
        rb.AddForce(fuerza, ForceMode2D.Impulse);
    }

    IEnumerator esperaBola()
    {
        yield return new WaitForSeconds(3f);
        puedoLanzar = true;
        Debug.Log("puedo lanzar Bola");
    }
}
