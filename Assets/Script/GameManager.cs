using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameEnded = false; 

	public float restartDelay = 2f;

	public void CompletedGame (){

			Debug.Log ("Game Completed");
			finishGame ();
			Invoke ("finishGame", restartDelay); 
	
	}

	public void GameOver (){

		if (gameEnded == false)
		{
			gameEnded = true;
			Debug.Log ("Game Over");
			restartGame ();
			Invoke ("restartGame", restartDelay); 
		}
	}


	void restartGame ()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

	void finishGame ()
	{
		SceneManager.LoadScene ("MainMenu");
	}
}
