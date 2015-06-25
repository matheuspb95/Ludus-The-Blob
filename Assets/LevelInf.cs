using UnityEngine;
using System.Collections;

public class LevelInf : MonoBehaviour {
	public string NextLevel;
	private string CurrentLevel;
	// Use this for initialization
	void Start () {
		this.CurrentLevel = Application.loadedLevelName;
		GameObject.Find("LevelControl").GetComponent<LevelScript>().SetlastLevelPlayed(CurrentLevel);
		GameObject.Find("LevelControl").GetComponent<LevelScript>().SetNextLevel(NextLevel);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
