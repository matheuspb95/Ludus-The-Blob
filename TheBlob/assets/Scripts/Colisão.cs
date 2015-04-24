using UnityEngine;
using System.Collections;

public class Colisão : MonoBehaviour {
	public Animator Explosao;
	public float time;
	public SoundControler SoundExplosao;
	// Use this for initializationz
	void Start () {
		Explosao = GetComponent<Animator> ();
		GameObject.FindGameObjectWithTag("SoundControler");
		SoundExplosao = GameObject.FindGameObjectWithTag("SoundControler").GetComponent<SoundControler>();


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
			        SoundExplosao.MusicaExplosao();
					ScoreManager.score += 10;
					Explosao.SetTrigger("Reaction");
					Invoke ("DestroyNow", time);
		}	
	}
}