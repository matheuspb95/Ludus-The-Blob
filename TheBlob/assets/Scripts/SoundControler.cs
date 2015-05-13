using UnityEngine;
using System.Collections;

public class SoundControler : MonoBehaviour {
	public AudioSource Menu;
	public AudioSource GameOver;
	public AudioSource Explosao;
	public AudioSource Stage;
	void Start(){
		DontDestroyOnLoad (gameObject);
		if (GameObject.FindGameObjectsWithTag ("SoundControler").Length > 1) {
			Destroy(gameObject);	
		}
		switch (Application.loadedLevel) {
		case 0:	MusicaMenu(); break;
		case 3: case 5:case 6:MusicaStage();break;
		}
	}
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
	public void PlaySound(string sound){
		switch (sound){
		case "Explosao":MusicaExplosao(); break;
		}
	}
	void OnLevelWasLoaded(int level){
		if (level == 0) {
			MusicaMenu();
			Stage.Stop();
		}else if(level==4){
			Menu.Stop();
			MusicaStage();
		}else if(level == 3){
			Stage.Stop();
			MusicaGameOver();
		}
	}
}