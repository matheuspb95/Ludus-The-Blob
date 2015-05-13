using UnityEngine;
using System.Collections;

public class MorrerColisao : MonoBehaviour {
	private Animator Explosao;
	public float DelayTime;
	public int Life;
	private SoundControler SoundExplosao;
	private ScoreManager ScoreRef;
	public int ScoreToAdd;
	public bool LoadLevelOnKill, EnabledAnimations;
	public string Tag, SoundFX, KillAnimation, TakeDamageAnimation, SceneToLoad;
	// Use this for initializationz
	void Start () {
		Explosao = GetComponent<Animator> ();
	}
	void DestroyNow () {
		gameObject.Recycle();
		collider2D.enabled = true;
		if(LoadLevelOnKill)Application.LoadLevel (SceneToLoad);
	}
	void OnCollisionEnter2D(Collision2D cool){
		if (cool.gameObject.tag == Tag) {
			Life--;
			if(EnabledAnimations) Explosao.SetTrigger(TakeDamageAnimation);
			cool.gameObject.Recycle ();
			if(Life<=0) Kill();
		}	
	}
	void OnTriggerEnter2D(Collider2D cool){
		if (cool.gameObject.tag == Tag) {
			Life--;
			if(EnabledAnimations) Explosao.SetTrigger(TakeDamageAnimation);
			cool.gameObject.Recycle ();
			if(Life<=0) Kill();
		}	
	}
	void Kill(){
		collider2D.enabled = false;
		ScoreRef = GameObject.Find("Manager").GetComponent<ScoreManager>();
		GameObject.FindGameObjectWithTag("SoundControler").GetComponent<SoundControler>().PlaySound(SoundFX);
		ScoreRef.AddScore(ScoreToAdd);
		PlayerPrefs.SetInt("Actual Score", GameObject.Find("Manager").GetComponent<ScoreManager>().GetScore());
		if(EnabledAnimations) Explosao.SetTrigger(KillAnimation);
		Invoke ("DestroyNow", DelayTime);
	}
}