using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class checkpoint_manager : MonoBehaviour
{
  static public Vector3 lastpos = new Vector3 (26, 15, -25) ;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "checkpoint") 
        {
            Checkpoint _checkpoint = other.GetComponent<Checkpoint>() ;
            

            lastpos=_checkpoint.spawnpos.position;

        }
        
    }



}
