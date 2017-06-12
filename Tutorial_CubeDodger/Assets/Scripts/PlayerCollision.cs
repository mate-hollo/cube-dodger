using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerController playerController;

    private void OnCollisionEnter(Collision collision)
    {
		//Debug.Log(collision.collider.tag);

		//disable movement script when hitting obstacle and invoke game over state
		if (collision.collider.tag == "obstacle")
		{
			playerController.enabled = false;
			FindObjectOfType<GameManager>().endGame();
		}

		
    }

}
