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
         transform.Translate(transform.position.x, 5, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 moveDirectionWorld = transform.TransformDirection(moveDirection);
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }
}
