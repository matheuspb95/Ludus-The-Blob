﻿using UnityEngine;
using System.Collections;

public class Colisão : MonoBehaviour {
	public Animator Explosao;
	public float time;
	public SoundControler SoundExplosao;
	private ScoreManager Score;
	// Use this for initializationz
	void Start () {
		Explosao = GetComponent<Animator> ();

	}	
	// Update is called once per frame
	void Update () {
	}
	void DestroyNow () {
		gameObject.Recycle();
	}
	void OnCollisionEnter2D(Collision2D cool){
		if (cool.gameObject.tag == "BlobBullet") {
			         cool.gameObject.Recycle ();
			        Score = GameObject.Find("Manager").GetComponent<ScoreManager>();
			        GameObject.FindGameObjectWithTag("Manager").GetComponent<SoundControler>().MusicaExplosao();
			        Score.AddScore(Score.scoreaddnave);
			        Explosao.SetTrigger("Reaction");
					Invoke ("DestroyNow", time);
		}	
	}
}