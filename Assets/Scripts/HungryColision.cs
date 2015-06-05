using UnityEngine;
using System.Collections;

public class HungryColision : MonoBehaviour {
	public Animator AnimRef;
	public float hitpoints=0;
	public float addFood;
    public float max;

	public float GetMax(){
		return this.max;
		}
	

	void Start () {
	
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
