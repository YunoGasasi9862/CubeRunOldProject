using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    float minDistance = 0;
    public GameObject plane;
    private float delay = 0.5f;
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
            //yield return new WaitForSeconds(delay);
            GameObject ground = Instantiate(plane, position, plane.transform.rotation);
            minDistance += 10;
            Destroy(ground, 5f);

            yield return null;

        }
    }
}
