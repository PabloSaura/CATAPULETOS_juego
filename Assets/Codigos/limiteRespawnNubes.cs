using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limiteRespawnNubes : MonoBehaviour
{

    //private mantenY = this.position.y;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D (Collider2D Colision) {
        if (Colision.gameObject.name == "prefabNube16") {
            Colision.gameObject.transform.position = new Vector2 (-20.5f,0);
        }

    
        
         if (Colision.gameObject.name == "Nube10") {
            Colision.gameObject.transform.position = new Vector2 (-18,-5.9f);
        }
        
    }
}
