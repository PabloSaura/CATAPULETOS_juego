using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control_Arco : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            Vector2 arco_Posicion = transform.position;
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 Direccion = mousePosition - arco_Posicion;
            transform.right = Direccion;
            
    }
}
