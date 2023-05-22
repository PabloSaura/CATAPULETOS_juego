using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{

    public AudioClip bandaSonora1;
    public AudioClip clicMenu;
    public AudioClip sonidoDisparo;
    public AudioClip sonidoImpacto;
    public AudioClip sonidoBeso;


    private AudioSource hiloMusical;


    public GameObject scriptDuplicado;
    void Awake () {
        DontDestroyOnLoad(this.gameObject);

        if(scriptDuplicado == null) {
           scriptDuplicado = this.gameObject; 
        } else if (scriptDuplicado != null) {
            DestroyObject(this.gameObject);
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
        
    }


/*
    public void sonidoBesito () {
        hiloMusical.PlayOneShot(sonidoBesito, 1f);
    }
*/

}
