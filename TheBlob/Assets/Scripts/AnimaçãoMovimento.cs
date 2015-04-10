using UnityEngine;
using System.Collections;

public class AnimaçãoMovimento : MonoBehaviour {
	public Transform target;
	public Animator Gosma;
	// Use this for initialization
void Start () {
		Gosma = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
void Update () {
			
	}

  public void Animaçao(Vector3 Direçao){

		Vector3 targetDir = Direçao;

		float angle = Mathf.Atan2 (targetDir.y, targetDir.x) * Mathf.Rad2Deg;
		//Debug.Log (angle);
			if((angle >45) && angle <135){
				Gosma.SetTrigger ("MoveCima");
				transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
			}
			if((angle>315)&&(angle<360)||(angle>0)&&(angle<45)){
				Gosma.SetTrigger ("MoveDireita");
				transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
			}
			if((angle>135)&&(angle<225)){
				Gosma.SetTrigger ("MoveEsquerda");
				transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
			}
			if((angle>225)&&(angle<315)){
				Gosma.SetTrigger ("MoveBaixo");
				transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
			}
	}
}
