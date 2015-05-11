using UnityEngine;
using System.Collections;

public class ControlPlayer : MonoBehaviour {
	private UnityJellySprite body;
	public float Acceleration=1;
	public float tapSpeed=0.5f;
	private float lastTapTime=0;
	private shoot shootRefer;
	public AnimaçãoMovimento animacao;
	public MoveTest Anim;
	public float MaxVelocity;

	// Use this for initialization
	void Start () {
		body = transform.parent.GetComponent<UnityJellySprite>();
		lastTapTime=0;
		shootRefer = transform.parent.GetComponent<shoot> ();
		Physics2D.IgnoreLayerCollision (LayerMask.NameToLayer("Player"),LayerMask.NameToLayer("PlayerBullets"));
	}
	
	// Update is called once per frame
	void Update () {
		foreach (Touch touch in Input.touches) {
			RaycastHit hit;
			Physics.Raycast (Camera.main.ScreenToWorldPoint (touch.position), Vector3.forward, out hit, 1000);
			if (hit.collider!=null && hit.collider.CompareTag ("Player")) {
				if(touch.phase == TouchPhase.Began){
					if((Time.time - lastTapTime) < tapSpeed){
						body.Stop();
					}
					lastTapTime = Time.time;
				}
				if (touch.phase == TouchPhase.Moved) {
					if(touch.deltaPosition.magnitude > 2){
						//Debug.Log("move");
						body.AddForce (touch.deltaPosition.normalized * Acceleration);
						Anim.AnimationMove(touch.deltaPosition);
						//animacao.Animaçao(touch.deltaPosition);
					}
				}	
			} else{
				if(touch.phase == TouchPhase.Began){
					shootRefer.Shoot(Camera.main.ScreenToWorldPoint (touch.position));
				}
			}
		}
	}
}