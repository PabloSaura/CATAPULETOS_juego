using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limiteRespawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D (Collider2D Colision) {
        if (Colision.gameObject.name == "CapsuleDerecha") {
            Colision.gameObject.transform.position = new Vector2 (0,10);
        }

         if (Colision.gameObject.name == "CapsuleIzquierda") {
            Colision.gameObject.transform.position = new Vector2 (0,10);
        }
    }
}
