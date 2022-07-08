using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < player.position.z)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, player.position.z); //snaps to players location
        }
    }
}
