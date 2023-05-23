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

<<<<<<< HEAD
    public int Vida_Capsule_Izquierda, Puntos_Izquierda;
    public int Vida_Capsule_Derecha, Puntos_Derecha;
=======
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
>>>>>>> b0981c138e8e5d22630536a3099a21b0026c8b9c


    //Capsules
    public GameObject cap1;
    public GameObject cap2;


    public static float velocidadCapsulas = 1.5f;

    void Awake()
    {
        // Esto en realidad habría que quitarlo, el script solo hace falta en la 
        // escena principal y hacer que no desapareza dará bugs cuando se quiera
        // jugar más de una vez
        //DontDestroyOnLoad(gameObject); ///ESTO ES PARA QUE NO SE DESTRUYA (video23 GUI Moises)
        Vida_Capsule_Derecha = Vida_Capsule_Izquierda = Max_Vida_Capsules;
        Puntos_Derecha = Puntos_Izquierda = 0;
        GameObject animacionIzquierda = Instantiate(personajesSeleccionados.PersonajeIzquierda, cap1.transform.position, cap1.transform.rotation, cap1.transform);
        GameObject animacionDerecha = Instantiate(personajesSeleccionados.PersonajeDerecha, cap2.transform.position, cap2.transform.rotation, cap2.transform);
        animacionDerecha.GetComponent<SpriteRenderer>().flipX = true;
    }


    public void IniciaPosiciones()
    {
        cap1.transform.position = new Vector2(-10.5f, -5);
        cap2.transform.position = new Vector2(10.5f, -5);
        Besito = false;
    }

<<<<<<< HEAD
    void OnGUI(){
        GUI.skin = miSkin;
        GUI.Label(new Rect(812,20,150,80),"Ronda: "+Ronda.ToString(),"estiloJuego");
        //GUI.Label(new Rect(20,20,150,80),"Vida: "+vidas.ToString(),"estiloScore");
        //GUI.Label(new Rect(100,20,150,80),"Score: "+score.ToString(),"estiloScore");
        GUI.Label(new Rect(100,20,150,80),"Puntos: "+Puntos_Izquierda.ToString(),"estiloJuego");
        //GUI.Label(new Rect(180,20,150,80),"Enemigos: "+enemigos.ToString(),"estiloScore");
        //GUI.Label(new Rect(Anchopantalla-100,20,200,100),"Nombre Juego", "estiloTitulo"); /// el primero sería (380,x,x,x)
        ///imagen
        //GUI.DrawTexture(new Rect(Screen.width-200,20,80,80),logoJuego);


    }
    /*
        public void IniciaPosicion1(){
            cap1.transform.position = new Vector2(21,-6.1f); 
        }

        public void IniciaPosicion2(){
            cap2.transform.position = new Vector2(-21,-6.1f);
        }
    */
=======
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

>>>>>>> b0981c138e8e5d22630536a3099a21b0026c8b9c


}
