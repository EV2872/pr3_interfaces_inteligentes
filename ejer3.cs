using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer3 : MonoBehaviour
{
    public Vector3 moveDirection = Vector3.forward;
    public float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        if (speed < 1) {
            speed = 1;
        }
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        // Multiplicar la dirección del movimiento
        // Esto duplicará las coordenadas de la dirección del movimiento
        moveDirection *= 2;
        // Duplicar la velocidad manteniendo la dirección del movimiento
        // Esto duplicará la velocidad sin cambiar la dirección
        // speed *= 2;
        // Cambiar la velocidad mínima a 1
        if (speed < 1) {
            speed = 1;
        }
        // Mover el cubo en la dirección especificada con la velocidad determinada
        Vector3 translation = moveDirection.normalized * speed * Time.deltaTime;
        transform.Translate(translation);
        // Comprobar si la posición del cubo tiene y>0
        if (transform.position.y > 0) {
            transform.Translate(transform.position.x, 0, transform.position.y);
            // Realiza alguna acción específica si la posición y es mayor que 0
        }
    }
}
