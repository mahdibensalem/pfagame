using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam_follow : MonoBehaviour
{
    public Transform player;
    public float smoothspeed=0.125f;
    public Vector3 cam_settings;

    private void FixedUpdate()

    {
        Vector3 last_position= player.position + cam_settings;
        Vector3 smoothedposition = Vector3.Lerp(transform.position, last_position, smoothspeed);

        transform.position = smoothedposition ;
        transform.LookAt(player);
    }

}
