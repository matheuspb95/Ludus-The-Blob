using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {
	public string Scene;
	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown(){
		Application.LoadLevel (Scene);
	}
	public void Load(string scene){
		Application.LoadLevel (scene);
	}
}
