using UnityEngine;
using System.Collections;

public class MoveTest : MonoBehaviour {
	public float a;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 force = (Vector2)transform.position - (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Debug.Log (force);
		GetComponent<JellySprite>().AddForce(a*force.normalized);
		//rigidbody2D.AddForce (-1 * force.normalized);
	}
}
