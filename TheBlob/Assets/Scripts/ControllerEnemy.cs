using UnityEngine;
using System.Collections;

public class ControllerEnemy : MonoBehaviour {
	private GameObject player;
	public float velocity;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Paredes"), LayerMask.NameToLayer("Inimigos"));
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 target = player.transform.position - transform.position;
		float angle = Mathf.Atan2(target.y, target.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

		angle = rigidbody2D.rotation;
		float dirx = velocity*Mathf.Cos(angle*Mathf.Deg2Rad)/100;
		float diry = velocity*Mathf.Sin(angle*Mathf.Deg2Rad)/100;
		Vector2 direction = new Vector2(dirx,diry);
		rigidbody2D.velocity = direction;
	}
}
