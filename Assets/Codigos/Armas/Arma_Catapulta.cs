using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma_Catapulta : MonoBehaviour
{
    //Armas
    //public GameObject Catapulta1;
    //public GameObject Catapulta2;

    //Proyectil y Velocidad
    //public GameObject bola;
    //public float velocidadBola = 3.0f; 

    /*
    public float fuerzaLanzamiento = 10f;
    public Rigidbody2D bolaPrefab;
    private Rigidbody2D catapultaRB;
    */

    // Start is called before the first frame update
    void Start()
    {
        //catapultaRB = GetComponent<Rigidbody2D>();
        /*
        GetComponent <Rigidbody>().angularVelocity = new Vector2(0,-6);
        //StartCoroutine(stoparm);
        */
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
            if (Input.GetKeyDown(KeyCode.E) == true)
        {
            LanzarBola();
        }
        
        void LanzarBola();
        {
        
        Rigidbody2D bola = Instantiate(bolaPrefab, transform.position, Quaternion.identity); // Crear una instancia de la bola en la posición de la catapulta

        
        Vector2 direccionLanzamiento = transform.right; // Obtener la dirección de lanzamiento

        
        bola.AddForce(transform.right * fuerzaLanzamiento, ForceMode2D.Impulse); // Aplicar una fuerza al rigidbody de la bola para lanzarla
        }
        */

        }
}


        /*
        if(Input.GetKeyDown(KeyCode.Space) == true) {
            Debug.Log("Pulsé [Space]");
            Input.GetAxis("Horizontal");
            Input.GetAxis("Vertical");
        }
        

        if(Input.GetKeyDown(KeyCode.E) == true) {
            
            Instantiate(bola, new Vector3(transform.position.x,transform.position.y,0), Quaternion.identity);
        }
        
        /*
        IEnumerator stoparm(){
                yield return new WaitForSeconds(.35f); 
                GetComponent <Rigidbody>().angularVelocity = new Vector2(0,-6);
        }
        */


