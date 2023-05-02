using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento1 : MonoBehaviour
{
    GameObject miObjeto;
    // Start is called before the first frame update
    void Start()
    {
        miObjeto = GameObject.Find("MainObject");
    }

    // Update is called once per frame
    void Update()
    {
        
        


        if (MainScript.Besito != true) {
        Debug.Log( "avan" );
                //Movimiento de la Capsule
          transform.Translate(-1/300f,0,0);
        }



    }

    //Comprobación de contacto físico entre Capsules
    void OnCollisionEnter2D(Collision2D otroObjeto) {
        if ( otroObjeto.gameObject.name == "Capsule2") {
        MainScript.Besito = true;
        Debug.Log( "Me ha Besado [Capsule 1] <3" );
        }

    }
}
