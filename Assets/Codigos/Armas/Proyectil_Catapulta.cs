using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil_Catapulta : MonoBehaviour
{
    GameObject AudioManager;

    audioManager mainAudio;


    // Start is called before the first frame update
    void Start()
    {
        AudioManager = GameObject.Find("AudioManager");
        mainAudio = AudioManager.GetComponent<audioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == "CapsuleIzquierda") {
            Destroy(this.gameObject);
            mainAudio.impactaCatapulta (); //Sonido
            mainAudio.GritaM2 (); //Sonido Grito
        }

        if (collision.gameObject.name == "CapsuleDerecha") {
            Destroy(this.gameObject);
            mainAudio.impactaCatapulta (); //Sonido
            mainAudio.GritaH2 (); //Sonido Grito
        }
    }
}
