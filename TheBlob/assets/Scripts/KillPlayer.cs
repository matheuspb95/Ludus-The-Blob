using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {
	// Use this for initialization
//	public GameObject[] hearts;
	public static int death=0;
	void Start () {
		death=0;
	}	
	// Update is called once per frame
	void Update () {
	}
	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Enemy"){
			death++;
			coll.gameObject.Recycle();					
		}
		if (death == 3){
			PlayerPrefs.SetInt("Actual Score", GameObject.Find("Manager").GetComponent<ScoreManager>().GetScore());
			Application.LoadLevel("gameover");
		}
	}
}
