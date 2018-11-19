using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coneMovement : MonoBehaviour
{
    
    public float conespeed = 600;
    float movement = 0;
    
    

    //cone movement
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
    }
    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -conespeed);
        if(conespeed>300f)
        {
            conespeed -= 0.01f;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.tag == "Asteroid")
        {
            
            Destroy(col.gameObject);
        }
    }
}