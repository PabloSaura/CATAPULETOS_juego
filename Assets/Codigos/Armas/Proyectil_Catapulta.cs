using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil_Catapulta : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == "CapsuleIzquierda") {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.name == "CapsuleDerecha") {
            Destroy(this.gameObject);
        }
    }
}
