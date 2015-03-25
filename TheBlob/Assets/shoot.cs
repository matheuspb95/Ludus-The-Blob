using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {
	public float BulletVelocity;

	public float bulletOffset;

	public int angleVariation;

	public GameObject BulletPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {



	}

	public void Shoot(Vector3 position){
		Debug.Log ("Shoot");
		Vector2 direction = transform.position - position;
		GameObject NewBullet = BulletPrefab.Spawn (transform.position);
		NewBullet.rigidbody2D.velocity = direction.normalized * BulletVelocity;
	}
}
