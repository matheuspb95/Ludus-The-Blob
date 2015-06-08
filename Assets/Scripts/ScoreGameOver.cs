using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreGameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent <Text> ().text = "" + PlayerPrefs.GetInt("Actual Score");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
