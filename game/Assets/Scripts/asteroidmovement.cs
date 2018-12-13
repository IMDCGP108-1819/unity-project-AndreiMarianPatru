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
    {//make the asteroids move quickly over time
        if (makeItHarder >= 0.05f)
        {
            makeItHarder = makeItHarder- 0.01f;
        }

      //make asteroids move towards the player
        float step = speed * Time.deltaTime*1/makeItHarder;
        transform.position = Vector3.MoveTowards(transform.position, Vector3.zero, step);
     //destroy the asteroids which colide with the player
        if (transform.position.x == 0)
            Destroy(obj);
    }
   
    
}

