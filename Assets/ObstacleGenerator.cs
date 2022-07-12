using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    int numberofobstacles = 150;
    float minz=20.0f, maxz=970f;
    float minX=-5.7f, maxX=3.2f;
    public GameObject obstacle;

    private void Start()
    {
        StartCoroutine(SpawnObstacles());
    }
    IEnumerator SpawnObstacles()
    {

        Vector3 pos;
        for (int i = 0; i < numberofobstacles; i++)
        {
            pos.x = Random.Range(minX, maxX);
            pos.z = Random.Range(minz, maxz);
            GameObject obstaclebody = Instantiate(obstacle, pos, Quaternion.identity); 


        }
        yield return null;
    }
}
