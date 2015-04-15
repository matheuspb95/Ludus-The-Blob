using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {
	// Use this for initialization
//	public GameObject[] hearts;



	public static int death=0;
	void Start () {
		death=0;
		ScoreManager.score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
	}
	
	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Enemy"){

//			Destroy(hearts[death]);
//			Debug.Log(death);
			death++;
			coll.gameObject.Recycle();
			//Application.LoadLevel("gameover");
					
		
		}
		if (death == 3){
		Application.LoadLevel("gameover");
		}
	}
}
