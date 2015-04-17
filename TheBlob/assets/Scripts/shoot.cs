using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {
	public float BulletVelocity;
	public float bulletOffset;
	public int angleVariation;
	public GameObject BulletPrefab;
	private float nextFire;
	public float FirePerSecond;
	// Use this for initialization
	void Start () {
		Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Paredes"), LayerMask.NameToLayer("PlayerBullets"));
		Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("PhysicalBody"), LayerMask.NameToLayer("PlayerBullets"));
	}
	
	// Update is called once per frame
	void Update () {

	}
	public void Shoot(Vector3 position){
		if(nextFire < Time.fixedTime){
			//Debug.Log ("shoot1");
			nextFire = Time.fixedTime + Mathf.Pow(FirePerSecond, -1);
			Debug.Log (nextFire);
			Vector2 direction = position - transform.position;
			GameObject NewBullet = BulletPrefab.Spawn (transform.position);
			NewBullet.rigidbody2D.velocity = direction.normalized * BulletVelocity;
		}
	}
}