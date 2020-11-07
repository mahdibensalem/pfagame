using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trompoline : MonoBehaviour
{
    public Rigidbody rbball;
    void Start()
    {
        rbball = GameObject.Find("player").GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            rbball.AddForce(Vector3.up * 1700f);
        }

    }

}