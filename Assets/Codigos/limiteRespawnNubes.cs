using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//DEPRECATED
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

        Debug.Log(Colision.gameObject.name);
        if (Colision.gameObject.name.StartsWith("prefabNube")) {
            Colision.gameObject.transform.position = new Vector2 (-20.5f,Colision.gameObject.transform.position.y);
        }

    
        
  
        
    }
}
