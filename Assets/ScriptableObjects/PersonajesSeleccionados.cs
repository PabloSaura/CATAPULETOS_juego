using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PersonajesSeleccionados", menuName = "CATAPULETOS_juego/PersonajesSeleccionados", order = 0)]
public class PersonajesSeleccionados : ScriptableObject
{
    public GameObject PersonajeIzquierda, PersonajeDerecha;
}