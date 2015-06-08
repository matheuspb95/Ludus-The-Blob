using UnityEngine;
using System.Collections;

public class LifeManager : MonoBehaviour {
	public int life;
	private MorrerColisao VidaPlayer;
	void Start () {
		VidaPlayer = GameObject.FindGameObjectWithTag ("Player").GetComponent<MorrerColisao> ();
	}
	// Update is called once per frame
	void Update () {
		if (VidaPlayer.Life < life) {
			gameObject.renderer.enabled = false;
		}
	}
}