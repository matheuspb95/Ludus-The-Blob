﻿using UnityEngine;
using System.Collections;

public class AnimaçãoMovimento : MonoBehaviour {
	public Transform target;
	public Animator Gosma;
	// Use this for initialization

  public void Animaçao(Vector3 Direçao){

		Vector3 targetDir = Direçao;

		float angle = Mathf.Atan2 (targetDir.y, targetDir.x) * Mathf.Rad2Deg;
		Debug.Log (angle);
		if ((angle>=45) && angle<=135){
			Gosma.SetTrigger ("MoveCima");

		}
	
	
	}


		


	void Start () {
		Gosma = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	

}
}