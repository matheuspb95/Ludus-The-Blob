using UnityEngine;
using System.Collections;

public class StarsScore : MonoBehaviour {
	public int StarScore;
	public static int Required;
	// Use this for initialization
	void Start () {
				if (GameObject.Find("Manager").GetComponent<ScoreManager>().GetScore() < StarScore  ) {
						//gameObject.SetActive (false);
						gameObject.renderer.enabled = false;
				}
		}
	// Update is called once per frame
	void Update () {
		if (GameObject.Find("Manager").GetComponent<ScoreManager>().GetScore() > StarScore  ) {
			gameObject.renderer.enabled = true;
		}	
	}	
}
