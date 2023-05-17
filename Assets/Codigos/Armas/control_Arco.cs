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

    // Start is called before the first frame update
    void Start()
    {
        Arma_Arco = mainObject.GetComponent<Arma_Arco>();
        mainObject = GameObject.Find("MainObject");

        puntos = new GameObject [numeroDePuntos];

        for (int i = 0; i < numeroDePuntos; i++) {
            puntos[i] = Instantiate(point, Arma_Arco.puntoDisparo.transform.position, Quaternion.identity);
            puntos[i].transform.position = PointPosition(i * espacioEntrePuntos);
        }
    }

    // Update is called once per frame
    void Update()
    {
            Vector2 arco_Posicion = transform.position;
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Direccion = mousePosition - arco_Posicion;
            transform.right = Direccion;
            
    }

    Vector2 PointPosition(float t) {
        Vector2 position = (Vector2)Arma_Arco.puntoDisparo.transform.position + (Direccion.normalized * Arma_Arco.velocidadFlecha * t) + 0.5f * Physics2D.gravity * (t * t);
        return position;
    }
}
