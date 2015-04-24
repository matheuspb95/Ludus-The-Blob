using UnityEngine;
using System.Collections;

public class SoundControler : MonoBehaviour {
	public AudioSource Menu;
	public AudioSource GameOver;
	public AudioSource Explosao;
	public AudioSource Stage;

	public void MusicaMenu(){
		Menu.Play();		
	}
	public void MusicaExplosao(){	
		Explosao.Play();
	}	
	public void MusicaStage(){	
		Stage.Play();
	}
	public void MusicaGameOver(){
		GameOver.Play();			
	}
	void Start () {
		DontDestroyOnLoad (transform.gameObject);
	}




	
	




		}
