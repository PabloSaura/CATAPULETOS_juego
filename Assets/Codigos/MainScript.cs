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

    public int Vida_Capsule_Izquierda, Puntos_Izquierda;
    public int Vida_Capsule_Derecha, Puntos_Derecha;

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
        cap1.transform.position = new Vector2(-10.5f, -5.9f);
        cap2.transform.position = new Vector2(10.5f, -5.9f);
        Besito = false;
    }

    void OnGUI(){
        GUI.skin = miSkin;
        GUI.Label(new Rect(870,40,150,80),"RONDA: "+Ronda.ToString(),"estiloJuego");
        //GUI.Label(new Rect(20,20,150,80),"Vida: "+vidas.ToString(),"estiloScore");
        //GUI.Label(new Rect(100,20,150,80),"Score: "+score.ToString(),"estiloScore");
        GUI.Label(new Rect(510,20,150,80),""+Puntos_Izquierda.ToString(),"estiloJuego");
        GUI.Label(new Rect(1369,20,150,80),""+Puntos_Derecha.ToString(),"estiloJuego");
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


}
