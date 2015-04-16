using UnityEngine;
using System.Collections;

public class Colisão : MonoBehaviour {
	public Animator Explosao;
	public float time;
	public static int starscore;
	// Use this for initializationz
	void Start () {
		Explosao = GetComponent<Animator> ();
	}	
	// Update is called once per frame
	void Update () {
	}
	void DestroyNow () {
		gameObject.Recycle();
	}
	void OnCollisionEnter2D(Collision2D cool){
		if (cool.gameObject.tag == "BlobBullet") {
					cool.gameObject.Recycle ();
					audio.Play();
					ScoreManager.score += 10;
					Explosao.SetTrigger("Reaction");
					Invoke ("DestroyNow", time);
		}	
	}
}
