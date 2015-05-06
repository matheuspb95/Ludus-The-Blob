using UnityEngine;
using System.Collections;

public class StartScene : MonoBehaviour {
	public GameObject Player, Score, ProgressBar, Lives, Stars, SoundController;
	// Use this for initialization
	void Awake () {
		Instantiate (Player);
		Instantiate (Score);
		Instantiate (ProgressBar);
		Instantiate (Lives);
		Instantiate (Stars);
	}
	void Start(){
		Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Paredes"), LayerMask.NameToLayer("PlayerBullets"));
		Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("PhysicalBody"), LayerMask.NameToLayer("PlayerBullets"));
		if (GameObject.FindGameObjectWithTag ("SoundControler") == null)
						(Instantiate (SoundController) as GameObject).GetComponent<SoundControler>().MusicaStage();
	}
}