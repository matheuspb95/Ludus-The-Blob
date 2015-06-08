using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoveTest : MonoBehaviour {
	public float ForceMultiplier;
	public float MassMultiplier;
	public float MinDrag;
	public float MaxDrag;
	public int DragMultiplier;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
//		Vector2 force = (Vector2)transform.position - (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
//		foreach (GameObject point in GameObject.FindGameObjectsWithTag("ReferencePoint")) {
//			float drag = Vector2.Distance(point.transform.position,transform.position+(Vector3)force.normalized);//Camera.main.ScreenToWorldPoint(Input.mousePosition)
//			drag = Mathf.Pow(drag,DragMultiplier);
//			Debug.Log(""+point.name+" Drag: "+ drag);
//			point.rigidbody2D.drag = drag*MassMultiplier;
//
//			if(point.name == "JellySprite Central Ref Point"){
//				if(drag < MinDrag) drag = MinDrag;
//				point.rigidbody2D.drag = drag*MassMultiplier;
//				point.rigidbody2D.AddForce(-ForceMultiplier*force.normalized);
//
//			}
//		}
	}

	public void AnimationMove(Vector3 direction){
		foreach (GameObject point in GameObject.FindGameObjectsWithTag("ReferencePoint")) {
			float drag = Vector2.Distance(point.transform.position,transform.position+(Vector3)direction.normalized);//Camera.main.ScreenToWorldPoint(Input.mousePosition)
			drag = Mathf.Pow(drag,DragMultiplier);
			point.rigidbody2D.drag = drag*MassMultiplier;
			if(drag > MaxDrag) drag = MaxDrag;
			//Debug.Log(""+point.name+" Drag: "+ drag);
			if(point.name == "JellySprite Central Ref Point"){
				if(drag < MinDrag) drag = MinDrag;
				point.rigidbody2D.drag = drag*MassMultiplier;
				//point.rigidbody2D.AddForce(-ForceMultiplier*direction.normalized);

			}
		}
	}

	public void ResetDrag(){
		foreach (GameObject point in GameObject.FindGameObjectsWithTag("ReferencePoint")) {
			point.rigidbody2D.drag = 1;
		}
	}
}
