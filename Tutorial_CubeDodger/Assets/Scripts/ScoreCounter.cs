using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {

	public Transform player;
	public Text scoreText;
	
	
	// Update is called once per frame
	void Update () {

		//scoreText.text = player.position.z.ToString("0");

		int playerScore = (int)player.position.z;
		++playerScore;

		if (playerScore % 100 == 0)
			scoreText.color = Color.red;
		else
			scoreText.color = Color.white;

		scoreText.text = playerScore.ToString();

		//Debug.Log(player.position.z);


	}
}
