using UnityEngine;
using System.Collections;

public class MoveTest : MonoBehaviour {
	public float ForceMultiplier;
	public float MassMultiplier;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//		Vector2 force = (Vector2)transform.position - (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
//		//Debug.Log (force);
//		GetComponent<JellySprite>().AddForce(ForceMultiplier*force.normalized);
//		//rigidbody2D.AddForce (-1 * force.normalized);
//		foreach (GameObject point in GameObject.FindGameObjectsWithTag("ReferencePoint")) {
//			float NewMass = Vector2.Distance(point.transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition));
//			if(NewMass > 0.5){NewMass = NewMass*NewMass*NewMass;
//				NewMass = NewMass * 3;
//				NewMass = NewMass/100;}
//			Debug.Log(NewMass);
//			point.rigidbody2D.mass = NewMass*MassMultiplier;
//		}
	}

	public void AnimationMove(Vector3 direction){
		foreach (GameObject point in GameObject.FindGameObjectsWithTag("ReferencePoint")) {
			//direction = direction * 2;
			float NewMass = Vector2.Distance(point.transform.position, (direction + transform.position));
				//Vector2.Distance(point.transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition));
			if(NewMass > 1){
				NewMass = NewMass*NewMass*NewMass*NewMass*NewMass;
				NewMass = NewMass/50;
			}else {
				NewMass = 1;			
			}
			Debug.Log(NewMass);
			point.rigidbody2D.mass = NewMass*MassMultiplier;
		}
	}
}
