using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeManager : MonoBehaviour {
	Text timetext;                      // Reference to the Text component.
	public int VictoryTime;
	void Awake ()
	{
		// Set up the reference.
		timetext = GetComponent <Text> ();
		
		// Reset the score.
		//score ;
	}
	
	
	void Update ()
	{
		// Set the displayed text to be the word "Score" followed by the score value.
		timetext.text = " " + Time.timeSinceLevelLoad;
		if(Time.timeSinceLevelLoad>=VictoryTime){
			Application.LoadLevel("victory");
		}
	}
}