using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextoRonda : MonoBehaviour
{

    private TMP_Text TMPRonda;

    private void Start()
    {
        TMPRonda = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        TMPRonda.text = MainScript.Ronda.ToString();
    }
}
