using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class mvtSphere : MonoBehaviour
{
    public float speed = 500f;
    public float limiteVelocity = 10f;
    public Rigidbody rb;
    private float RayDistance = 1f;
    public Vector3 respown;
    public bool dead= false;
    

    void Start() 
    {
        rb = GetComponent<Rigidbody>();
        
    }
    void FixedUpdate()
    { 
        /*******************moving*************/
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            rb.AddForce(movement * speed * Time.deltaTime);
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, limiteVelocity);
            Debug.Log(IsGrounded());


        /******************jumping ******************/
        if (Input.GetKey(KeyCode.Space) && (IsGrounded()) == true)
        {
            rb.AddForce(Vector3.up * 5000f * Time.deltaTime);
            speed =50f;
        }
        /************** if dead restart place  *************************/
        if (dead)
        {
          
            transform.position = checkpoint_manager.lastpos ;
            dead = false;

        }

        if (IsGrounded())
        {
            speed = 500f;

        }

    }

    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, RayDistance);
    }

    /**************** dead test ************************/
    void OnCollisionEnter(Collision other)

    {
        if (other.gameObject.tag == "obstacle")
        {
            dead = true;
           
           
        }
       
    }
    

}