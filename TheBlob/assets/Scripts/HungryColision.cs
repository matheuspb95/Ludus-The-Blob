﻿using UnityEngine;
using System.Collections;

public class HungryColision : MonoBehaviour {
	public Animator AnimRef;
	public float hitpoints=0;
	public float tamMax;
	public float addFood;
	void Start () {

	}
	void Update () {
			}
	void OnTriggerEnter2D(Collider2D cool){
		if (cool.gameObject.tag == "Food") {
						hitpoints += addFood;
			AnimRef.SetTrigger("Eat");
				}
		if(hitpoints>= tamMax){
		 Application.LoadLevel("victory");


			}
		
		}
	
}
