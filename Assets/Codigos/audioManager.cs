using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class audioManager : MonoBehaviour
{

    public AudioClip bandaSonora1;
    public AudioClip clicMenu;
    public AudioClip sonidoDisparo;
    public AudioClip sonidoImpacto;
    public AudioClip sonidoBeso;


    private AudioSource hiloMusical;
    private Scene escenaActual;



    public GameObject scriptDuplicado;
    void Awake () {
        DontDestroyOnLoad(this.gameObject);

        if(scriptDuplicado == null) {
           scriptDuplicado = this.gameObject; 
        } else if (scriptDuplicado != null) {
            Destroy(this.gameObject);
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

}
