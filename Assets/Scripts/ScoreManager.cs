using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
	private int score;        // The player's score.

	Text text;                      // Reference to the Text component.
	public int scoreaddnave = 10;
	public void AddScore(int n){
		score += n; 
		text.text = " " + score;
	}

	public int GetScore(){
		return this.score;
		}

	public  void SetScore(int n){
		this.score = n;
		}

	void Start ()
	{
		// Set up the reference.
		score = 0;
		text = GameObject.Find("ScoreText").GetComponent <Text> ();
		// Reset the score.
		//score ;
	}
	
}