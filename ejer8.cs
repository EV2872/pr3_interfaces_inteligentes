using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer8 : MonoBehaviour
{
    public float speed = 0;
    public float speedRotation = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        if (movimientoHorizontal != 0) {
            transform.Rotate(Vector3.up, movimientoHorizontal * speedRotation * Time.deltaTime);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
