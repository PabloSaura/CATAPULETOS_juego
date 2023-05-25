using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catapulta_prueba : MonoBehaviour
{
    public GameObject bolaPrefab;
    public float fuerzaLanzamiento = 10f;
    public float variacionX = 1f;
    public float distanciaDestruccion = 27f; ///para que se destruyaaa

    private GameObject bolaLanzada;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            LanzarBola();
        }

        if (bolaLanzada != null && Vector2.Distance(transform.position, bolaLanzada.transform.position) >= distanciaDestruccion)
        {
            Destroy(bolaLanzada);
            bolaLanzada = null; ///null mirar tutotial de nuevo
        }
    }

    private void LanzarBola()
    {
        if (bolaLanzada != null)
        {
            Destroy(bolaLanzada);
        }

        bolaLanzada = Instantiate(bolaPrefab, transform.position, Quaternion.identity);
        Rigidbody2D rb = bolaLanzada.GetComponent<Rigidbody2D>();

        // Aplica una fuerza en la dirección hacia la derecha con una variación en el eje X
        Vector2 fuerza = new Vector2(fuerzaLanzamiento + Random.Range(-variacionX, variacionX), 0f);
        rb.AddForce(fuerza, ForceMode2D.Impulse);
    }
}