using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    float minDistance = 0;
    public GameObject plane;
    void Start()
    {
        StartCoroutine(SpawnGround());
    }

  
   IEnumerator SpawnGround()
    {

        while(true)
        {
             
            Vector3 position= transform.position;
            
            position.z = minDistance;
            GameObject ground = Instantiate(plane, position, plane.transform.rotation);
            minDistance += 10;
            Destroy(ground, 5f);
            yield return null;
        

        }
    }
}
