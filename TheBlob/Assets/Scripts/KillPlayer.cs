﻿using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
	}
	
	void OnCollisionEnter2D(Collision2D other)
	{
		Die();
	}
	
	void Die()
	{
		Application.LoadLevel(Application.loadedLevel);
	}
	//	void OnCollisionEnter2D(Collision2D cool){
	//if (cool.gameObject.tag == "Enemy") {
	//Application.LoadLevel("teste");
	
	
}
