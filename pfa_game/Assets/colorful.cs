using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorful : MonoBehaviour
{
    Renderer Rend;
   
    // Start is called before the first frame update
    void Start()
    {
        Rend= GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
       
        Debug.Log(Rend.material.color);
        
    }
}
