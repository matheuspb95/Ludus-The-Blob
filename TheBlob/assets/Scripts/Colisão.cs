﻿using UnityEngine;
using System.Collections;

public class Colisão : MonoBehaviour {
	// Use this for initializationz
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	 
	
	}

	void OnCollisionEnter2D(Collision2D cool){
		if (cool.gameObject.tag == "BlobBullet") {
					gameObject.Recycle ();
					cool.gameObject.Recycle ();
					ScoreManager.score += 10;
		}
	
	}
}
