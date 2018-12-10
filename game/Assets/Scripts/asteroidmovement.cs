using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidmovement : MonoBehaviour
{

    public Transform target;
    public float speed;
    public GameObject obj;
    public float makeItHarder = 1f;



    // Update is called once per frame
    void Update()
    {
        if (makeItHarder >= 0.05f)
        {
            makeItHarder = makeItHarder- 0.01f;
        }

      
        float step = speed * Time.deltaTime*1/makeItHarder;
        transform.position = Vector3.MoveTowards(transform.position, Vector3.zero, step);

        if (transform.position.x == 0)
            Destroy(obj);
    }
   
    
}

