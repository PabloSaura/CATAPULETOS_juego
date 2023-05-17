using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flecha : MonoBehaviour
{
 
    Rigidbody2D rb; 
    bool haImpactado;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (haImpactado == false){
            float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    } 

    private void OnCollisionEnter2D(Collision2D collision){
        haImpactado = true;
        rb.velocity = Vector2.zero;
        rb.isKinematic = true;
    }
}
