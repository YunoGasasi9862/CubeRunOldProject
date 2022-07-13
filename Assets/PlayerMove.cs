using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 20f;
    public float jumpforce=10f;
    float gravity = -9.81f;
    bool canjump;
    Vector3 velocity;
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

            transform.Translate(Vector3.right * speed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);


        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            canjump = true;
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            canjump = false;
            velocity.y += gravity * Time.deltaTime;
        }
        if(canjump)
        {
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse); //so it only JUMPS once on IMPULSE!!

        }

    }
}
