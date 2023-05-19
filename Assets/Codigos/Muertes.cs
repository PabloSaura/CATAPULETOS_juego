using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muertes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D otroObjeto){
        
        Debug.Log(otroObjeto.gameObject.name);
        /*
        if (otroObjeto.gameObject.name == "PuntaFlecha"){
        MainScript.Vida_Capsules --;
        
        //MainScript.Vida_Capsule2--;
        }
        */
    }
}
