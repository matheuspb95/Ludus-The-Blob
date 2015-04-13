using UnityEngine;
using System.Collections;

public class MivimentAnimation : MonoBehaviour {
	public Transform target;
	public Animator Gosma;
	// Use this for initialization
	void Start () {
		Gosma =GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 targetDir = target.position - transform.position;
		Vector3 forward = transform.right;
		float angle = Vector3.Angle(targetDir, forward);
		if ((angle == 90)&& (targetDir.y>=0)){
			Gosma.SetBool ("MoveCima",true);
			
			
			
			
			
		}
	}
}