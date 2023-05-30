using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control_Arco : MonoBehaviour
{
    
    public GameObject point;
    GameObject[] puntos;
    public int numeroDePuntos;
    public float espacioEntrePuntos;
    Arma_Arco Arma_Arco;
    GameObject mainObject;

    Vector2 Direccion;

    public Transform punteroArco;

    //bool lanzaFlecha = false;
    bool puedoLanzar = true;


    // Start is called before the first frame update
    void Start()
    {
        mainObject = GameObject.Find("MainObject");
        Arma_Arco = mainObject.GetComponent<Arma_Arco>();

        // Esto hay que arreglarlo, instancia chorrocientos puntos nada más empezar y no los borra
        //puntos = new GameObject[numeroDePuntos];

        //for (int i = 0; i < numeroDePuntos; i++)
        //{
        //    puntos[i] = Instantiate(point, Arma_Arco.puntoDisparo.transform.position, Quaternion.identity);
        //    puntos[i].transform.position = PointPosition(i * espacioEntrePuntos);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "Arco_Pivote2") {
            Vector2 arco_Posicion = transform.position;
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Direccion = mousePosition - arco_Posicion;
            transform.right = Direccion;

            puedoLanzar = false;
            StartCoroutine(esperaFlecha());
        }

        if (gameObject.name == "Arco_Pivote1") {
            Vector2 arco_Posicion = transform.position;
            Vector2 mousePosition = -punteroArco.position;
            //Vector2 mousePosition = punteroArco.position.x , punteroArco.position.y;
            Direccion = mousePosition - arco_Posicion;
            transform.right = Direccion;

            Debug.Log ("Arco_Pivote2");

            puedoLanzar = false;
            StartCoroutine(esperaFlecha());
        }


        /* //CONTROL para Bando_Derecha
            if (gameObject.name == "Arco_Pivote2") {
            Vector2 arco_Posicion = transform.position;
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Direccion = mousePosition - arco_Posicion;
            transform.right = Direccion;
        }
        */

    }

     IEnumerator esperaFlecha()
    {
        yield return new WaitForSeconds(3f);
        puedoLanzar = true;
        Debug.Log("puedo lanzar Flecha");
    }

    Vector2 PointPosition(float t)
    {
        Vector2 position = (Vector2)Arma_Arco.puntoDisparo.transform.position + (Direccion.normalized * Arma_Arco.velocidadFlecha * t) + 0.5f * Physics2D.gravity * (t * t);
        return position;
    }
}
