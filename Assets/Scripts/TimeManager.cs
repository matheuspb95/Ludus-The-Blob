using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeManager : MonoBehaviour {
	Text timetext;                      // Reference to the Text component.
	public int VictoryTime;
	void Awake ()
	{
	}
	void Update ()
	{
		if(Time.timeSinceLevelLoad>=VictoryTime){
			PlayerPrefs.SetInt("Actual Score", GameObject.Find("Manager").GetComponent<ScoreManager>().GetScore());
			Application.LoadLevel("victory");
		}
	}
}