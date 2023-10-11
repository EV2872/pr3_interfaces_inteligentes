using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer1 : MonoBehaviour
{
    public float velocidad =0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Tecla pulsada: " + KeyCode.UpArrow);
            Debug.Log("Resultado = " + velocidad * Input.GetAxis("Vertical"));
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            Debug.Log("Tecla pulsada: " + KeyCode.DownArrow);
            Debug.Log("Resultado = " + velocidad * Input.GetAxis("Vertical"));
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            Debug.Log("Tecla pulsada: " + KeyCode.RightArrow);
            Debug.Log("Resultado = " + velocidad * Input.GetAxis("Horizontal"));
        } else if (Input.GetKey(KeyCode.LeftArrow)) {
            Debug.Log("Tecla pulsada: " + KeyCode.LeftArrow);
            Debug.Log("Resultado = " + velocidad * Input.GetAxis("Horizontal"));
        }
    }
}
