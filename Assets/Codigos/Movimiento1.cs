using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento1 : MonoBehaviour




{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        

        transform.Translate(-1/100f,0,0);

    }

    void OnCollisionEnter2D(Collision2D Capsule2) {
        Debug.Log( "Me ha besado" );
    }
}
