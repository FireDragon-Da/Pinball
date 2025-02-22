using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Paddle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public KeyCode keyOrder;
    public float force;

    //the rigibody on this object
    public Rigidbody2D rb;

    private void Start()
    {
        
    }

    private void Update()
    {

        if (Input.GetKey(keyOrder)){

            rb.AddTorque(force);
        }else{
            rb.AddTorque(-force);
        }
    }

    
}
