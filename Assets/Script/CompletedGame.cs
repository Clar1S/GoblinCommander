using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletedGame : MonoBehaviour {

	public GameManager gameManager;

	void OnTriggerEnter () {
		gameManager.CompletedGame ();
	}

}
