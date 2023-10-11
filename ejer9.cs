using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cubo"))
        {
            Debug.Log("Colision con cubo");
        } else if (collision.gameObject.CompareTag("Esfera")) {
            Debug.Log("Colision con espera");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cubo"))
        {
            Debug.Log("Colision con cubo");
        } else if (other.gameObject.CompareTag("Esfera")) {
            Debug.Log("Colision con espera");
        }
    }
}
