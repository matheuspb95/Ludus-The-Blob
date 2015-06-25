using UnityEngine;
using System.Collections;

public class LoadPreviousLevel : MonoBehaviour {
	private string Scene;
	// Use this for initialization
	void Start () {
		this.Scene = GameObject.Find ("LevelControl").GetComponent<LevelScript> ().GetlastLevelPlayed();
	}
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown(){
		Application.LoadLevel (this.Scene);
	}
	public void Load(){
		Application.LoadLevel (this.Scene);
	}
}