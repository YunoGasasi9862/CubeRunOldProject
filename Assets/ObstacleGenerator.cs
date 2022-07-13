using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    int numberofobstacles = 50;
    float minz=20.0f, maxz=970f;
    float minX=-5.7f, maxX=3.2f;
    public GameObject obstacle;

    private void Start()
    {
        StartCoroutine(SpawnObstacles());
    }
    IEnumerator SpawnObstacles()
    {

        Vector3 pos=transform.position;
        for (int i = 0; i < numberofobstacles; i++)
        {
            float Number =  Random.Range(minz, maxz);// check if there are larger gaps
            if  ( Number > 30)
            {
                pos.z = Number;
            }
            else
            {
                pos.z = Number + 30;
            }
            pos.x = Random.Range(minX, maxX);
            
            GameObject obstaclebody = Instantiate(obstacle, pos, Quaternion.identity); 


        }
        yield return null;
    }
}
