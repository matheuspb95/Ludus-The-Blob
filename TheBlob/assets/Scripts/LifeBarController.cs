using UnityEngine;
using System.Collections;

public class LifeBarController : MonoBehaviour {
	float maxHp;
	float currentHp;
	GameObject redLifeBar;
	public float hpLerpSpeed;
	Vector3 target;
	HungryColision scriptRef;

	void Start () {
		target = transform.localScale;
		scriptRef = GameObject.FindGameObjectWithTag ("Player").GetComponent<HungryColision> ();
		maxHp = scriptRef.tamMax;
	}

	void Update () {
		AdjustGreenBar ();
	}

	void AdjustGreenBar(){
		target.x = currentHp;
			currentHp = scriptRef.hitpoints / maxHp;
		if(transform.localScale.x < 0f){
			transform.localScale = new Vector3(0,1,1);
		}
		transform.localScale = Vector3.Lerp (transform.localScale, target, Time.deltaTime * hpLerpSpeed);
	}
}
