using UnityEngine;
using System.Collections;
// Play clip TimeSeconds slower
public class AnimationTime : MonoBehaviour {
	public float TimeSeconds; //Para alterar manualmente
	Animator bar;
	float aux;
	// Use this for initialization
	void Start () {
		bar = GetComponent<Animator> ();
		aux = Mathf.Pow(TimeSeconds, -1);//Converte Numero para velocidade do clip
		bar.speed = aux;//The playback speed of the Animator. 1 is normal playback speed.
	}
//	 Update is called once per frame
	void Update () {

	}
}
