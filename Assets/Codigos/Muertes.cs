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

    void OnTriggerEnter2D(){
        //Debug.Log("Besitoooooo");
        MainScript.Vida_Capsule1--;
        MainScript.Vida_Capsule2--;
    }
}
