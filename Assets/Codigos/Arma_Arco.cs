using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma_Arco : MonoBehaviour
{
    //Armas
    //public GameObject Arco1;
    public GameObject Arco2;

    //Proyectil y Velocidad
    public GameObject flecha;
    public float velocidadFlecha = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) == true) {
            Debug.Log("Pulsé [E]");
            Input.GetAxis("Horizontal");
            Input.GetAxis("Vertical");
            //this.GetComponentInParent<AudioSource>().PlayOneShot(sonidoBola);
            //Instantiate(flecha, new Vector3(transform.position.x,transform.position.y,0), Quaternion.identity);
        }
    }

    //Averiguar botones de Mando
     void OnGUI(){
        Event eventoBoton = Event.current;
        Debug.Log ( "Juego con Mandito" + eventoBoton.button);
    }
}
