using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespownSphere : MonoBehaviour
{
    public GameObject destroyversion;
    void Start()
    {
        transform.position = new Vector3(-77, 181, -213);
        Instantiate(destroyversion, transform.position, transform.rotation);
    }

    void Update()
    {
        transform.position = destroyversion.transform.position;
    }
}
