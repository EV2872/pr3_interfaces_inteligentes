using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer4_esfera : MonoBehaviour
{
    public float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(Vector3.up *  speed);
        } else if (Input.GetKey(KeyCode.S)) {
            transform.Translate(Vector3.down *  speed);
        } else if (Input.GetKey(KeyCode.A)) {
            transform.Translate(Vector3.left *  speed);
        } else if (Input.GetKey(KeyCode.D)) {
            transform.Translate(Vector3.right *  speed);
        }
    }
}
