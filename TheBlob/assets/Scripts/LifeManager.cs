using UnityEngine;
using System.Collections;

public class LifeManager : MonoBehaviour {
	public int life;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (KillPlayer.death == life) {
			gameObject.SetActive (false);
		}
	}
}