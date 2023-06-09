using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

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
    private int _Vida_Capsule_Izquierda;
    public int Vida_Capsule_Izquierda
    {
        get => _Vida_Capsule_Izquierda;
        set
        {
            value = Mathf.Max(0, value);
            _Vida_Capsule_Izquierda = value;
            if (_Vida_Capsule_Izquierda <= 0)
            {
                IniciaPosicionIzquierda();
            }
        }
    }
    private int _Puntos_Izquierda;
    public int Puntos_Izquierda
    {
        get => _Puntos_Izquierda;
        set
        {
            _Puntos_Izquierda = value;
            TextoPuntuacionIzquierda.text = value.ToString();
        }
    }
    [SerializeField]
    private int _Vida_Capsule_Derecha;
    public int Vida_Capsule_Derecha
    {
        get => _Vida_Capsule_Derecha;
        set
        {
            value = Mathf.Max(0, value);
            _Vida_Capsule_Derecha = value;
            if (_Vida_Capsule_Derecha <= 0)
            {
                IniciaPosicionDerecha();
            }
        }
    }
    private int _Puntos_Derecha;
    public int Puntos_Derecha
    {
        get => _Puntos_Derecha;
        set
        {
            _Puntos_Derecha = value;
            TextoPuntuacionDerecha.text = value.ToString();
        }
    }


    ///mi Skin
    public GUISkin miSkin;

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
        IniciaPosicionDerecha();
        IniciaPosicionIzquierda();
        Besito = false;
    }

    public void IniciaPosicionIzquierda()
    {
        cap1.transform.position = new Vector2(-10.5f, -5.9f);
        cap1.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        Vida_Capsule_Izquierda = 10;
    }

    public void IniciaPosicionDerecha()
    {
        cap2.transform.position = new Vector2(10.5f, -5.9f);
        cap2.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        Vida_Capsule_Derecha = 10;
    }

    //void OnGUI(){
    //    GUI.skin = miSkin;
    //    GUI.Label(new Rect(870,40,150,80),"RONDA: "+Ronda.ToString(),"estiloJuego");
    //    //GUI.Label(new Rect(20,20,150,80),"Vida: "+vidas.ToString(),"estiloScore");
    //    //GUI.Label(new Rect(100,20,150,80),"Score: "+score.ToString(),"estiloScore");
    //    GUI.Label(new Rect(510,20,150,80),""+Puntos_Izquierda.ToString(),"estiloJuego");
    //    GUI.Label(new Rect(1369,20,150,80),""+Puntos_Derecha.ToString(),"estiloJuego");
    //    //GUI.Label(new Rect(180,20,150,80),"Enemigos: "+enemigos.ToString(),"estiloScore");
    //    //GUI.Label(new Rect(Anchopantalla-100,20,200,100),"Nombre Juego", "estiloTitulo"); /// el primero sería (380,x,x,x)
    //    ///imagen
    //    //GUI.DrawTexture(new Rect(Screen.width-200,20,80,80),logoJuego);


    //}
    /*
        public void IniciaPosicion1(){
            cap1.transform.position = new Vector2(21,-6.1f); 
        }

        public void IniciaPosicion2(){
            cap2.transform.position = new Vector2(-21,-6.1f);
        }
    */


}
