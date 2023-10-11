using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer6 : MonoBehaviour
{
    GameObject cubo;
    GameObject esfera;
    public float speed = 0;
    // Start is called before the first frame update
    void Start()
    {   
        cubo = GameObject.FindWithTag("Cubo");
        esfera = GameObject.FindWithTag("Esfera");
    }

    // Update is called once per frame
    void Update()
    {
        if (esfera != null && cubo != null) {
            Vector3 direccion = esfera.transform.position - cubo.transform.position;
            direccion = direccion.normalized;
            cubo.transform.Translate(direccion * speed * Time.deltaTime);
        }
    }
}
