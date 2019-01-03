using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabspawner : MonoBehaviour {
    float x;
    float y;
    float z;
    Vector3 pos;
    public GameObject prefab1, prefab2,prefab3, prefab4, prefab5, prefab6, prefab7;

   

    public float spawnRate = 5f;

    float nextSpawn = 0f;
    int whattospwan;
    

	// Update is called once per frame
	void Update () {
		if(Time.time>nextSpawn)
        {
           
            whattospwan = Random.Range(1, 7);
            x = Random.Range(-10, 10);
            y = Random.Range(-10, 10);
            z = 1;
            if (x < 1 && x > -1)
                x = Random.Range(2, 4);
            if (y < 1 && y > -1)
                y = Random.Range(1, 2);
            pos = new Vector3(x, y, z);
            transform.position = pos;
            switch (whattospwan)
            {
                case 1:
                    Instantiate(prefab1, transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(prefab2, transform.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(prefab3, transform.position, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(prefab4, transform.position, Quaternion.identity);
                    break;
                case 5:
                    Instantiate(prefab5, transform.position, Quaternion.identity);
                    break;
                case 6:
                    Instantiate(prefab6, transform.position, Quaternion.identity);
                    break;
                case 7:
                    Instantiate(prefab7, transform.position, Quaternion.identity);
                    break;

            }
            //Instantiate(prefab, transform.position, Quaternion.identity);
            nextSpawn = Time.time + spawnRate;
            if(spawnRate>=0.30f)
            {
                spawnRate -= 0.01f;
            }
            
        }
        
    }

}
