using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNubes : MonoBehaviour
{
    public static nubes;
    public static float velocidadNubes = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform.position = movimientoNubes;
        transform.Translate(velocidadNubes * Time.deltaTime,0,0);
        /// HAY QUE AÑADIR LA FUNCION DE RANDOM PARA QUE UNAS VAYAN MÁS RAPIDAS Y OTRAS MÁS LENTAS
        
    }
}
