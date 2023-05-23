using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainScript : MonoBehaviour

{
    public TMP_Text TextoPuntuacionIzquierda;
    public TMP_Text TextoPuntuacionDerecha;
    public PersonajesSeleccionados personajesSeleccionados;
    //Booleano de Comprobación de evento cuando Capsules contactan
    public static bool Besito = false;

    //Rondas
    public static int Ronda = 3;


    //Vida Capsules
    public static int Max_Vida_Capsules = 10; // lo he cambiado de 5 --> 3

    [SerializeField]
    private int _Puntos_Izquierda;
    public int Puntos_Izquierda
    {
        get => _Puntos_Izquierda;
        set
        {
            value = Mathf.Max(0, value);
            _Puntos_Izquierda = value;
            TextoPuntuacionIzquierda.text = _Puntos_Izquierda.ToString();
        }
    }
    [SerializeField]
    private int _Vida_Capsule_Izquierda;
    public int Vida_Capsule_Izquierda
    {
        get => _Vida_Capsule_Izquierda;
        set
        {
            value = Mathf.Clamp(value, 0, Max_Vida_Capsules);
            _Vida_Capsule_Izquierda = value;
            if (_Vida_Capsule_Izquierda <= 0)
            {
                IniciaPosicionIzquierda();
            }
        }
    }
    [SerializeField]
    private int _Puntos_Derecha;
    public int Puntos_Derecha
    {
        get => _Puntos_Derecha;
        set
        {
            value = Mathf.Max(0, value);
            _Puntos_Derecha = value;
            TextoPuntuacionDerecha.text = _Puntos_Derecha.ToString();
        }
    }
    [SerializeField]
    private int _Vida_Capsule_Derecha;
    public int Vida_Capsule_Derecha
    {
        get => _Vida_Capsule_Derecha;
        set
        {
            value = Mathf.Clamp(value, 0, Max_Vida_Capsules);
            Debug.Log("Dañando derecha, nueva vida es: " + value);
            _Vida_Capsule_Derecha = value;
            if (_Vida_Capsule_Derecha <= 0)
            {
                IniciaPosicionDerecha();
            }
        }
    }


    //Capsules
    public GameObject personajeIzquierda;
    public GameObject personajeDerecha;


    public static float velocidadCapsulas = 0.7f;

    void Awake()
    {
        // Esto en realidad habría que quitarlo, el script solo hace falta en la 
        // escena principal y hacer que no desapareza dará bugs cuando se quiera
        // jugar más de una vez
        //DontDestroyOnLoad(gameObject); ///ESTO ES PARA QUE NO SE DESTRUYA (video23 GUI Moises)
        Vida_Capsule_Derecha = Vida_Capsule_Izquierda = Max_Vida_Capsules;
        Puntos_Derecha = Puntos_Izquierda = 0;
        GameObject animacionIzquierda = Instantiate(personajesSeleccionados.PersonajeIzquierda, personajeIzquierda.transform.position, personajeIzquierda.transform.rotation, personajeIzquierda.transform);
        GameObject animacionDerecha = Instantiate(personajesSeleccionados.PersonajeDerecha, personajeDerecha.transform.position, personajeDerecha.transform.rotation, personajeDerecha.transform);
        animacionDerecha.GetComponent<SpriteRenderer>().flipX = true;
    }


    public void IniciaPosiciones()
    {
        IniciaPosicionDerecha();
        IniciaPosicionIzquierda();
        Besito = false;
    }

    public void IniciaPosicionIzquierda()
    {
        personajeIzquierda.transform.position = new Vector2(-10.5f, -5);
        personajeIzquierda.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        Vida_Capsule_Izquierda = Max_Vida_Capsules;
    }

    public void IniciaPosicionDerecha()
    {
        personajeDerecha.transform.position = new Vector2(10.5f, -5);
        personajeDerecha.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        Vida_Capsule_Derecha = Max_Vida_Capsules;
    }



}
