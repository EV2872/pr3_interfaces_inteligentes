using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer12 : MonoBehaviour
{
    public float speed = 0;
    public float speedRotation = 0;
    public float friction_ = 0;
    GameObject esfera;
    // Start is called before the first frame update
    void Start()
    {
        esfera = GameObject.FindWithTag("Esfera");
    }

    // Update is called once per frame
    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        if (movimientoHorizontal != 0) {
            transform.Rotate(Vector3.up, movimientoHorizontal * speedRotation * Time.deltaTime);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        //transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (esfera != null) {
            Vector3 direccion = esfera.transform.position - transform.position;
            direccion = direccion.normalized;
            transform.Translate(direccion * speed * Time.deltaTime);
        }
    }
}
