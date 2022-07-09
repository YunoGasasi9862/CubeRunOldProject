using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    float minDistance = 0;
    public GameObject plane;
    //private float delay = 0.5f;
    public int platformNumber = 200;
    void Start()
    {
        StartCoroutine(SpawnGround());
    }

  
   IEnumerator SpawnGround()
    {

          for(int i=0; i< platformNumber; i++)
        {
            Vector3 position = transform.position;

            position.z = minDistance;
            //yield return new WaitForSeconds(delay);
            GameObject ground = Instantiate(plane, position, plane.transform.rotation);
            minDistance += 10;
            // Destroy(ground, 10f);

        }

        yield return null;

        
    }
}
