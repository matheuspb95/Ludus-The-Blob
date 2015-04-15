using UnityEngine;
using System.Collections;

public class StarsScore : MonoBehaviour {
	public int StarScore;
	// Use this for initialization
	void Start () {
				if (ScoreManager.score < StarScore  ) {
						gameObject.SetActive (false);
				}
		}
	// Update is called once per frame
	void Update () {
	
	}
	
}
