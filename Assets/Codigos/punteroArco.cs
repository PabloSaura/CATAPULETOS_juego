using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class punteroArco : MonoBehaviour
{

    public float velocidad = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hoz = Input.GetAxis("Horizontal")*velocidad;
        float ver = Input.GetAxis("Vertical")*velocidad;

        if(transform.position.x > 15){
            transform.position = new Vector2(15, transform.position.y);
        }
        if(transform.position.x < -15){
            transform.position = new Vector2(-15, transform.position.y);
        }

        if(transform.position.y > 9){
            transform.position = new Vector2(transform.position.x, 9);
        }
        if(transform.position.y < -7){
            transform.position = new Vector2(transform.position.x,-7);
        }




        transform.Translate(hoz*Time.deltaTime, ver*Time.deltaTime, 0);
    }
}
