using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {
	public float BulletVelocity;
	public float bulletOffset;
	public int angleVariation;
	public GameObject BulletPrefab;
	private float nextFire;
	public float FirePerSecond;
	public void Shoot(Vector3 position){
		if(nextFire < Time.fixedTime){
			//Debug.Log ("shoot1");
			nextFire = Time.fixedTime + Mathf.Pow(FirePerSecond, -1);
			Vector2 direction = position - transform.position;
			GameObject NewBullet = BulletPrefab.Spawn (transform.position);
			NewBullet.rigidbody2D.velocity = direction.normalized * BulletVelocity;
		}
	}
}