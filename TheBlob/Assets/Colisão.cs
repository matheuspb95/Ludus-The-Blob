using UnityEngine;
using System.Collections;

public class Colisão : MonoBehaviour {
public	GameObject Alvo;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	 
	
	}

	void OnTriggerEnter2D(Collider2D cool){
		if (cool.gameObject.tag == "shoot") {
			Destroy(gameObject);
			Debug.Log("Destroy");
				
		
		}


		}

}
