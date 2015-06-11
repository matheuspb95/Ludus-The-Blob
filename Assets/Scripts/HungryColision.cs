using UnityEngine;
using System.Collections;

public class HungryColision : MonoBehaviour {
	public Animator AnimRef;
	public float hitpoints;
	private float addFood;
  	 public float max;

	public float GetMax(){
		return this.max;
		}


	void Start () {
		max = GameObject.Find ("Manager").GetComponent<FoodControl> ().Max;
		addFood = GameObject.Find ("Manager").GetComponent<FoodControl> ().AddFood;


	}
	void Update () {
			}
	 

	
	IEnumerator Example() {
				yield return new WaitForSeconds (1);
				Application.LoadLevel("victory");
		}

	void OnTriggerEnter2D(Collider2D cool){
		if (cool.gameObject.tag == "Food") {
						hitpoints += addFood;
			AnimRef.SetTrigger("Eat");
				}
		if(hitpoints>= max ){
		
			StartCoroutine(Example());
		    



			}
		
		}
	
}
