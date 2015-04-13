using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {
	// Use this for initialization
	public static int death=0;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
	}
	
	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Enemy"){
			death++;
			//Application.LoadLevel("gameover");
		}
		if (death == 3){
		Application.LoadLevel("gameover");
		}
	}
}
