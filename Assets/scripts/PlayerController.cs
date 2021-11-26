using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    private float speed = 50f;
    private float turnSpeed = 50f;
    private float horizontalInput;
    private float verticalInput;
    

    
    void Update()
    {
        //Tomamos eje vertical
        verticalInput = Input.GetAxis("Vertical");
        //tomamos eje horizontal
        horizontalInput = Input.GetAxis("Horizontal");
        //moviment hacia adelante
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        //moviment lateral
        //transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);

        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
