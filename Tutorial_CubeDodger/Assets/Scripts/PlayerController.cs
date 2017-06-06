using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody rb;

    // Use this for initialization
    void Start()
    {
       // rb.AddForce(0, 0, 500.0f);
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, 500.0f * Time.deltaTime);
    }
}
    
