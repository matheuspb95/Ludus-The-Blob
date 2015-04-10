using UnityEngine;
using System.Collections;

public class AnimaçãoMovimento : MonoBehaviour {
	//public Transform target;
	public Animator Gosma;
	public float ResetTime;
	public float Delay;
	private float ActualTime;
		// Use this for initialization
	void Start () {
		Gosma = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
			
	}

  public void Animaçao(Vector3 Direçao){
		if (ActualTime < Time.time) {
			ActualTime = Time.time + Delay;
			Vector3 targetDir = Direçao;
			//Debug.Log (targetDir.magnitude);
			float angle = Mathf.Atan2 (targetDir.y, targetDir.x) * Mathf.Rad2Deg;
			Debug.Log (angle);
			if((angle >45) && angle <135){
				Gosma.SetTrigger ("MoveCima");
				transform.rotation = Quaternion.AngleAxis(angle-90, Vector3.forward);//-90
			}
			if((angle>-45)&&(angle<45)){
				Gosma.SetTrigger ("MoveDireita");
				transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
			}
			if((angle<-135)||(angle>135)){
				Gosma.SetTrigger ("MoveEsquerda");
				transform.rotation = Quaternion.AngleAxis(angle-180, Vector3.forward);//-180
			}
			if((angle>-135)&&(angle<-45)){
				Gosma.SetTrigger ("MoveBaixo");
				transform.rotation = Quaternion.AngleAxis(angle-270, Vector3.forward);//-270
			}
		}
		Invoke ("ResetRotation", ResetTime);
	}

	void ResetRotation(){
		Debug.Log("ResetROtation");
		transform.rotation = Quaternion.AngleAxis(0, Vector3.forward);
	}
}
