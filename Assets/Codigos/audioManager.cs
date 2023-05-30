using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class audioManager : MonoBehaviour
{

    public AudioClip bandaSonora1;

    public AudioClip clicMenu;
    public AudioClip clicEleccion;
    public AudioClip clicHecho;

    public AudioClip sonidoDisparo_Flecha;
    public AudioClip sonidoImpacto_Flecha;

    public AudioClip sonidoDisparo_Catapulta;
    public AudioClip sonidoImpacto_Catapulta;
    
    public AudioClip sonidoBeso;

    public AudioClip sfxGritoH;
    public AudioClip sfxGritoM;

    public AudioClip sfxGritoH2;
    public AudioClip sfxGritoM2;


    private AudioSource hiloMusical;
    private Scene escenaActual;



    //public GameObject scriptDuplicado;
    public static audioManager Instance { get; private set; }

    void Awake () {
        if (Instance != null && Instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            Instance = this; 
            DontDestroyOnLoad(this);
        } 
    } //Fin Awake


    // Start is called before the first frame update
    void Start()
    {
        hiloMusical = GetComponent<AudioSource>();  //
        hiloMusical.clip = bandaSonora1;
        hiloMusical.loop = true;
        hiloMusical.Play();
    }


    // Update is called once per frame
    void Update()
    {
        escenaActual = SceneManager.GetActiveScene();
        if (escenaActual.name == "Start") {
            hiloMusical.pitch = 1f;
        } else if (escenaActual.name == "Main_NIvel"){
            hiloMusical.pitch = 1.33f;
        }
    }


/*
    public void sonidoBesito () {
        hiloMusical.PlayOneShot(sonidoBesito, 1f);
    }
*/

    public void clicBoton (){
        hiloMusical.PlayOneShot(clicMenu, 1f);
    }

    public void clicHechoPJ (){
        hiloMusical.PlayOneShot(clicHecho, 1f);
    }

    public void clicEleccionPJ (){
        hiloMusical.PlayOneShot(clicEleccion, 1f);
    }



    public void disparaFlecha (){
        hiloMusical.PlayOneShot(sonidoDisparo_Flecha, 1f);
    }

    public void impactaFlecha (){
        hiloMusical.PlayOneShot(sonidoImpacto_Flecha, 1f);
    }

    public void GritaH (){
        hiloMusical.PlayOneShot(sfxGritoH, 1f);
    }

    public void GritaM (){
        hiloMusical.PlayOneShot(sfxGritoM, 1f);
    }

    public void disparaCatapulta (){
        hiloMusical.PlayOneShot(sonidoDisparo_Catapulta, 1f);
    }

    public void impactaCatapulta (){
     hiloMusical.PlayOneShot(sonidoImpacto_Catapulta, 1f);
    }

    public void GritaH2 (){
        hiloMusical.PlayOneShot(sfxGritoH2, 1f);
    }

    public void GritaM2 (){
        hiloMusical.PlayOneShot(sfxGritoM2, 1f);
    }

    public void besitoTrue (){
        hiloMusical.PlayOneShot(sonidoBeso, 1f);
    }

}
