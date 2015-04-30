using UnityEngine;
using System.Collections;

public class SoundControlerMenu : MonoBehaviour {
	public AudioSource MenuSound;	
	void Awake() {
		   MenuSound.Play ();
		if(GameObject.Find("SoundControler")!= gameObject){
			Destroy(gameObject);
	        }

			DontDestroyOnLoad (transform.gameObject);

}
	          void OnLevelWasLoaded(int level) {
		       if (level == 3)
						Destroy (gameObject);
		
	    }
   }



