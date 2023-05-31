using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectorPersonajes : MonoBehaviour
{
    public PersonajesSeleccionados personajesSeleccionados;
    public GameObject[] personajesDisponibles => personajesSeleccionados.personajes;
    public Sprite[] spritesDisponibles;
    public int indiceSeleccionadoIzquierda, indiceSeleccionadoDerecha;
    public Image retratoIzquierda, retratoDerecha;
    private void Start()
    {
        Seleccionar(1, 0);
        Seleccionar(2, personajesDisponibles.Length - 1);
        retratoIzquierda.sprite = spritesDisponibles[indiceSeleccionadoIzquierda];
        retratoDerecha.sprite = spritesDisponibles[indiceSeleccionadoDerecha];
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
            indiceSeleccionadoIzquierda = (indiceSeleccionadoIzquierda + pasosADar) % (personajesDisponibles.Length);
            if (indiceSeleccionadoIzquierda < 0) indiceSeleccionadoIzquierda = personajesDisponibles.Length + indiceSeleccionadoIzquierda;
            if (indiceSeleccionadoIzquierda == indiceSeleccionadoDerecha)
            {
                indiceSeleccionadoIzquierda = (indiceSeleccionadoIzquierda + pasosADar) % (personajesDisponibles.Length);
                if (indiceSeleccionadoIzquierda < 0) indiceSeleccionadoIzquierda = personajesDisponibles.Length + indiceSeleccionadoIzquierda;
            }
            retratoIzquierda.sprite = spritesDisponibles[indiceSeleccionadoIzquierda];
            personajesSeleccionados.IndicePersonajeIzquierda = indiceSeleccionadoIzquierda;
        }
        else if (numeroDeJugador == 2)
        {
            indiceSeleccionadoDerecha = (indiceSeleccionadoDerecha + pasosADar) % (personajesDisponibles.Length);
            if (indiceSeleccionadoDerecha < 0) indiceSeleccionadoDerecha = personajesDisponibles.Length + indiceSeleccionadoDerecha;
            if (indiceSeleccionadoIzquierda == indiceSeleccionadoDerecha)
            {
                indiceSeleccionadoDerecha = (indiceSeleccionadoDerecha + pasosADar) % (personajesDisponibles.Length);
            }
            if (indiceSeleccionadoDerecha < 0) indiceSeleccionadoDerecha = personajesDisponibles.Length + indiceSeleccionadoDerecha;
            retratoDerecha.sprite = spritesDisponibles[indiceSeleccionadoDerecha];
            personajesSeleccionados.IndicePersonajeDerecha = indiceSeleccionadoDerecha;
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

    public void IrAMenuPrincipal()
    {
        SceneManager.LoadScene("Start");
    }

}