using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 20f;
    public float jumpforce=10f;
    public bool canJump = true;
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Vector3.forward * speed );  //VECTOR 3 FORWARD IS FOR Z DIRECTION, YAHOO!!!\\
        if(Input.GetKey(KeyCode.D))
        {

            rb.AddForce(Vector3.right * speed);

        }
        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * speed);


        }

        if(Input.GetKey(KeyCode.Space))
        {


            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse); //so it only JUMPS once on IMPULSE!!

        }
    }
}
