using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fatfet : MonoBehaviour
{
    public GameObject player;
    public GameObject playerdestroy;
    public mvtSphere scriptphere;
    public MeshRenderer meshplayer;

    public void Start()
    {
        scriptphere = player.GetComponent<mvtSphere>();
        meshplayer = player.GetComponent<MeshRenderer>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            meshplayer.enabled = true;
            Instantiate(playerdestroy, player.transform.position, transform.rotation);
            scriptphere.dead = true;

        }




    }
}
