

                    /*
                DEPRECATED
                    */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class inputArco : MonoBehaviour
{
    InputMaster controles;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        
    }

    void Awake () {
        controles = new InputMaster();

    
    }
}
