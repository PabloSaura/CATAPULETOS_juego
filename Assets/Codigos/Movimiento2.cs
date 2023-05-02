using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento2 : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (MainScript.Besito != true) {
        //Movimiento de la Capsule
        transform.Translate(1/300f,0,0) ;
        }
    }

//Comprobación de contacto físico entre Capsules
    void OnCollisionEnter2D(Collision2D otroObjeto) {
        if ( otroObjeto.gameObject.name == "Capsule1") {
        Debug.Log( "Me ha Besado [Capsule 2]<3" );
        }

    }

}
