using UnityEngine;
using System.Collections;

public class Meteor : MonoBehaviour {

	// Use this for initialization
	public Vector2 velocity = new Vector2(-4, 0);  	 	
	public float range;
	void Start () {
		rigidbody2D.velocity = velocity;
		transform.position = new Vector3(transform.position.x, transform.position.y - range * Random.value, transform.position.z);
		Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Paredes"), LayerMask.NameToLayer("Inimigos"));
	}
	}
	
	// Update is called once per frame
	

