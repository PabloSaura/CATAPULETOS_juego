using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour

{
    //Booleano de Comprobación de evento cuando Capsules contactan
    public static bool Besito = false;

    //Puntuación
    public static int Puntuación = 0;

    //Rondas
    public static int Ronda = 3;

    //Vida Capsules
    public static int Vida_Capsules = 100; //Esto es Pocentaje (A petición de Mariano)

    //Capsules
    public GameObject cap1;
    public GameObject cap2;

    public static float velocidadCapsulas = 3f;

    void Awake(){
        DontDestroyOnLoad(gameObject); ///ESTO ES PARA QUE NO SE DESTRUYA (video23 GUI Moises)
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {

        //Aquí todavía no hay nada
        Debug.Log (Ronda);
        Debug.Log (Vida_Capsules);

    }

    public void IniciaPosiciones(){
        cap1.transform.position = new Vector2(9,-5.7f);
        cap2.transform.position = new Vector2(-9,-5.7f);
        Besito = false;
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
