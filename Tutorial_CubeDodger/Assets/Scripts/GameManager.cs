using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameEnded = false;
	public float restartDelay = 1.0f;
	
	public void endGame ()
	{
		if (!gameEnded)
		{
			gameEnded = true;
			Debug.Log("GAME OVER");
			//Restart();
			Invoke("Restart", restartDelay);
		}
	}

	void Restart()
	{
		//SceneManager.LoadScene("level1");

		//loads active scene
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}
