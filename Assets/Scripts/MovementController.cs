using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{


    //variables definning
    float speed = 10f;

    float Horizontal = 0f;
    float Vartical = 0f;

    public Rigidbody rb;

    // Update is called once per frame
    void FixedUpdate()
    {
        //input gathering
        if (Input.GetKey("d"))
        {
            rb.transform.Translate(Vector3.right * Time.deltaTime);
        }    
        if (Input.GetKey("a"))
        {
            rb.transform.Translate(Vector3.left * Time.deltaTime);
        }    
        if (Input.GetKey("w"))
        {
            rb.transform.Translate(Vector3.forward * Time.deltaTime);
        }    
        if (Input.GetKey("s"))
        {
            rb.transform.Translate(Vector3.back * Time.deltaTime);
        }    


    }
}
