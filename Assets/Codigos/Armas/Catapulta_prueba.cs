using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catapulta_prueba : MonoBehaviour
{
    public GameObject bolaPrefab;
    public float fuerzaLanzamiento = 10f;
    public float variacionX = 27f; //medidas provisionales
    public float distanciaDestruccion = 27f; ///para que se destruyaaa

    bool lanzaBola = false;

    bool puedoLanzar = true;

    private GameObject bolaLanzada;
    public GameObject CapsuleIzquierda;
    public GameObject CapsuleDerecha;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && puedoLanzar == true)
        {
                    Debug.Log("lanzar");
            puedoLanzar = false;
            LanzarBola();
            StartCoroutine(esperaBola());
        }
        

        if (bolaLanzada != null && Vector2.Distance(transform.position, bolaLanzada.transform.position) >= distanciaDestruccion) // NULL: para indicar un valor no definido o desconocido (volver a ver el tuto)
        {
            Destroy(bolaLanzada);
            bolaLanzada = null; ///null: para indicar un valor no definido o desconocido (mirar tutotial de nuevo)
        }
    }
    
    private void LanzarBola()
    {
        if (bolaLanzada)
        {
            lanzaBola = true;
            Debug.Log (lanzaBola);
        }

        if (lanzaBola == true) {
            //Time.deltaTime
            //Queremos que al Instanciar una Bola salte un contador que no deje Instanciar otra en X tiempo

        }

        bolaLanzada = Instantiate(bolaPrefab, transform.position, Quaternion.identity);
        Rigidbody2D rb = bolaLanzada.GetComponent<Rigidbody2D>();

        // Aplica una fuerza en la dirección hacia la derecha con una variación en el eje X
        Vector2 fuerza = new Vector2(fuerzaLanzamiento + Random.Range(variacionX, variacionX), 27f); /// EL 27f ES LA FUERZA EN "Y" PARA QUE VAYA BOMBEADITA
        rb.AddForce(fuerza, ForceMode2D.Impulse);
    }

    IEnumerator esperaBola()
    {
        
        yield return new WaitForSeconds(3f);
        puedoLanzar = true;
        Debug.Log("puedo lanzar");
    }
}
