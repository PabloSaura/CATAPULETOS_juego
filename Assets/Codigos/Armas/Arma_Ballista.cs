using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma_Ballista : MonoBehaviour
{
    //Armas
    //public GameObject Ballista1;
    public GameObject Ballista2;

    //Proyectil y Velocidad
    public GameObject virote;
    public float velocidadVirote = 3.0f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Backspace) == true) {
            Debug.Log("Pulsé [Backspace]");
            Input.GetAxis("Horizontal");
            Input.GetAxis("Vertical");
        }
    }

}
