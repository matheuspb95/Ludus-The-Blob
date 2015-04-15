using UnityEngine;
using System.Collections;

public class SoundControler : MonoBehaviour {

	// Use this for initialization


	//function Awake () {

		//if(Application.loadedLevelName  == "Menu_Planets"){

			//DontDestroyOnLoad (transform.gameObject);
		//}



	//}





	void Start () {
		DontDestroyOnLoad (transform.gameObject);
	}
	
	// Update is called once per frame
	void Update () {

		if(Application.loadedLevelName  == "stage1"){
			
			Destroy (transform.gameObject);
		}
	
	}
}
