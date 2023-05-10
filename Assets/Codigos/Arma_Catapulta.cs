using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma_Catapulta : MonoBehaviour
{
    //Armas
    //public GameObject Catapulta1;
    public GameObject Catapulta2;

    //Proyectil y Velocidad
    public GameObject bola;
    public float velocidadBola = 3.0f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true) {
            Debug.Log("Pulsé [Space]");
            Input.GetAxis("Horizontal");
            Input.GetAxis("Vertical");
        }
    }
}
