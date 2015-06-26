using UnityEngine;
using System.Collections;

public class SpawnAleatorioInimigos : MonoBehaviour {
	public GameObject enemyPrefab;
	public float SpawnTime;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", SpawnTime, SpawnTime);
	}

	void Spawn(){
		float posx = Random.Range (-0.5f, 1.5f);
		float posy;
		do{
			posy = Random.Range (-0.5f, 1.5f);
		}
		while(posy>=0 && posy<=1);
		//Debug.Log(""+posx+" - "+posy);
		enemyPrefab.Spawn (Camera.main.ViewportToWorldPoint (new Vector3(posx, posy, 10)));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
