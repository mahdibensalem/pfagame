using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particelsystemfollow : MonoBehaviour
{
    public float speed;
    public Transform player ;
    void Start()
    {
        
    }
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);
        transform.position = Vector3.MoveTowards(transform.position, player.position, distance  *speed * Time.deltaTime);
    }
}
