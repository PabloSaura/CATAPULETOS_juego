using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PersonajesSeleccionados", menuName = "CATAPULETOS_juego/PersonajesSeleccionados", order = 0)]
public class PersonajesSeleccionados : ScriptableObject
{
    private void OnEnable()
    {
        hideFlags = HideFlags.DontUnloadUnusedAsset;
    }
    public int IndicePersonajeIzquierda = 0, IndicePersonajeDerecha = 5;
    public GameObject[] personajes;
    public GameObject PersonajeIzquierda { get => personajes[IndicePersonajeIzquierda]; }
    public GameObject PersonajeDerecha { get => personajes[IndicePersonajeDerecha]; }

}