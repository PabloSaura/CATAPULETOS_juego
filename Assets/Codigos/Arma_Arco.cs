using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Arma_Arco : MonoBehaviour
{
    //Armas
    //public GameObject Arco1;
    public GameObject Arco2;

    //Proyectil y Velocidad
    public GameObject flecha;
    public float velocidadFlecha = 3.0f;
    public Transform puntoDisparo;

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
        
        if (Input.GetMouseButtonDown(0)) {
            Disparo();
        }
    }

    //Averiguar botones de Mando
/*     void OnGUI(){
        Event eventoBoton = Event.current;
        Debug.Log ( "Juego con Mandito" + eventoBoton.button);
    }
*/

    void Disparo () {
        GameObject nuevaFlecha = Instantiate(flecha, puntoDisparo.position, puntoDisparo.rotation);
        Debug.Log(puntoDisparo.rotation.z);
        Debug.Log(puntoDisparo.rotation);

          Vector3 targetForward = puntoDisparo.rotation * Vector3.forward;
        Vector3 targetUp = puntoDisparo.rotation * Vector3.right;
        nuevaFlecha.GetComponent<Rigidbody2D>().velocity = targetUp * velocidadFlecha;
    }

    void FixedUpdate()
    {
        var gamepad = Gamepad.current;
        if (gamepad == null)
            return; // No gamepad connected.

        if (gamepad.rightTrigger.wasPressedThisFrame)
        {
            // 'Use' code here
        }

        Vector2 move = gamepad.leftStick.ReadValue();
        // 'Move' code here
    }
}
