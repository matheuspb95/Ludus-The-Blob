using UnityEngine;
using System.Collections;

public class AnimaçãoMovimento : MonoBehaviour {
	//public Transform target;
	private Animator Gosma;
	public float ResetTime, Delay, ActualTime;
	void Start () {
		Gosma = GetComponent<Animator> ();
	}
  	public void Animaçao(Vector3 Direçao){
		if (ActualTime < Time.time) {
			ActualTime = Time.time + Delay;
			float angle = Mathf.Atan2 (Direçao.y, Direçao.x) * Mathf.Rad2Deg;
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
		transform.rotation = Quaternion.AngleAxis(0, Vector3.forward);
	}
}