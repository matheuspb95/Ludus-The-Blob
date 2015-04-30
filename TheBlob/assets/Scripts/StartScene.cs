using UnityEngine;
using System.Collections;

public class StartScene : MonoBehaviour {
	public GameObject Player, Score, ProgressBar, Lives, Stars;
	// Use this for initialization

	void Awake () {

		Instantiate (Player);
		Instantiate (Score);
		Instantiate (ProgressBar);
		Instantiate (Lives);
		Instantiate (Stars);

	}

	void Start(){
		
		DontDestroyOnLoad (gameObject);	
		
	}


}
