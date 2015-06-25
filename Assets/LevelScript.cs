using UnityEngine;
using System.Collections;

public class LevelScript : MonoBehaviour {
	string LastLevelPlayed,NextLevel;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(transform.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public string GetlastLevelPlayed(){
		return this.LastLevelPlayed;
	}
	public void SetlastLevelPlayed(string LastLevel){
		this.LastLevelPlayed=LastLevel;
	}
	public string GetNextLevel(){
		return this.NextLevel;
	}
	public void SetNextLevel(string NextLevel){
		this.NextLevel=NextLevel;
	}
}
