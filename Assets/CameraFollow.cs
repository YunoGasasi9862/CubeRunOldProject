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
            transform.position = new Vector3(player.position.x, player.position.y+1, player.position.z-2); //snaps to players location
        }
    }
}
