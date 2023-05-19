using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectorPersonajes : MonoBehaviour
{
    public PersonajesSeleccionados personajesSeleccionados;
    [System.Serializable]
    public class ComboPersonajeYRetrato
    {
        public GameObject personaje;
        public Sprite sprite;
    }
    public List<ComboPersonajeYRetrato> personajesDisponibles;
    public int indiceSeleccionadoIzquierda, indiceSeleccionadoDerecha;
    public Image retratoIzquierda, retratoDerecha;
    private void Awake()
    {
        Seleccionar(1, 0);
        Seleccionar(2, personajesDisponibles.Count - 1);
        retratoIzquierda.sprite = personajesDisponibles[indiceSeleccionadoIzquierda].sprite;
        retratoDerecha.sprite = personajesDisponibles[indiceSeleccionadoDerecha].sprite;
    }

    public void SeleccionarSiguiente(int numeroDeJugador)
    {
        Seleccionar(numeroDeJugador, 1);
    }
    public void SeleccionarAnterior(int numeroDeJugador)
    {
        Seleccionar(numeroDeJugador, -1);
    }
    public void Seleccionar(int numeroDeJugador, int pasosADar)
    {
        // Esto de aquí es magia arcana para que la selección no te deje coger el mismo personaje dos veces
        // y que dé vueltas a los retratos de selección cuando haga falta
        if (numeroDeJugador == 1)
        {
            indiceSeleccionadoIzquierda = (indiceSeleccionadoIzquierda + pasosADar) % (personajesDisponibles.Count);
            if (indiceSeleccionadoIzquierda < 0) indiceSeleccionadoIzquierda = personajesDisponibles.Count + indiceSeleccionadoIzquierda;
            if (indiceSeleccionadoIzquierda == indiceSeleccionadoDerecha)
            {
                indiceSeleccionadoIzquierda = (indiceSeleccionadoIzquierda + pasosADar) % (personajesDisponibles.Count);
                if (indiceSeleccionadoIzquierda < 0) indiceSeleccionadoIzquierda = personajesDisponibles.Count + indiceSeleccionadoIzquierda;
            }
            retratoIzquierda.sprite = personajesDisponibles[indiceSeleccionadoIzquierda].sprite;
            personajesSeleccionados.PersonajeIzquierda = personajesDisponibles[indiceSeleccionadoIzquierda].personaje;
        }
        else if (numeroDeJugador == 2)
        {
            indiceSeleccionadoDerecha = (indiceSeleccionadoDerecha + pasosADar) % (personajesDisponibles.Count);
            if (indiceSeleccionadoDerecha < 0) indiceSeleccionadoDerecha = personajesDisponibles.Count + indiceSeleccionadoDerecha;
            if (indiceSeleccionadoIzquierda == indiceSeleccionadoDerecha)
            {
                indiceSeleccionadoDerecha = (indiceSeleccionadoDerecha + pasosADar) % (personajesDisponibles.Count);
            }
            if (indiceSeleccionadoDerecha < 0) indiceSeleccionadoDerecha = personajesDisponibles.Count + indiceSeleccionadoDerecha;
            retratoDerecha.sprite = personajesDisponibles[indiceSeleccionadoDerecha].sprite;
            personajesSeleccionados.PersonajeDerecha = personajesDisponibles[indiceSeleccionadoDerecha].personaje;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SeleccionarSiguiente(2);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SeleccionarAnterior(2);
        }

    }

}