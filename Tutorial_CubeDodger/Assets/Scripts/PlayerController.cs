using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;



    // Use this for initialization
    void Start()
    {
    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //add force to the player every frame
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        
        //add sideways force when a or d is pressed (ignore the object's mass with forcemode)
        
        if (Input.GetKey("a"))  
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        

        if (Input.GetKey("d"))
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

		if (rb.position.y < -1.0f)
		{
			FindObjectOfType<GameManager>().endGame();
		}
        
        
        
    }
}
    
