using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioControl : MonoBehaviour
{
    GameObject AudioManager;

    audioManager mainAudio;

    void Start()
    {
        AudioManager = GameObject.Find("AudioManager");
        mainAudio = AudioManager.GetComponent<audioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sonidoMenu () {
        mainAudio.clicBoton();
    }

    public void sonidoEleccion () {
        mainAudio.clicEleccionPJ();
    }

    public void sonidoHecho () {
        mainAudio.clicHechoPJ();
    }



    public void sonidoArco () {
        mainAudio.disparaFlecha();
    }

     public void impactaFlecha () {
        mainAudio.disparaFlecha();
    }
}
