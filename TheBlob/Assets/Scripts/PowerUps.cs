using UnityEngine;
using System.Collections;
public class PowerUps : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}
	void OnCollisionEnter2D(Collision2D coll) {
			if(coll.gameObject.tag== "FireRate"){
			shoot c= new shoot();
			c.FireRate= 1;
		}
	/*void OnCollisionEnter2D(Collision2D cool){
		if (cool.gameObject.tag == "FireRate") {
			shoot.FireRate= shoot.FireRate -0.1;
	}
}*/
	}
}
