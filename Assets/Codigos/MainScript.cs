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
    public static int Vida_Capsules = 3; /// lo he cambiado de 5 --> 3

    public GameObject cap1;
    public GameObject cap2;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {

        //Aquí todavía no hay nada

    }

    public void IniciaPosiciones(){
        cap1.transform.position = new Vector2(11,-7);
        cap2.transform.position = new Vector2(-11,-7);
    }

    

}
