﻿using UnityEngine;
using System.Collections;

public class Food : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D cool){
		if (cool.gameObject.tag == "Player") {
			gameObject.Recycle();
		}
	}

}
