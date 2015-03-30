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
		float posx = Random.Range (-1f, 2f);
		while (posx > 0 && posx < 1) {
			posx = Random.Range (-1f, 2f);
		}
		float posy = Random.Range (-1f, 2f);
		while (posy > 0 && posy < 1) {
			posy = Random.Range (-1f, 2f);
		}
		Debug.Log(""+posx+" - "+posy);
		enemyPrefab.Spawn (Camera.main.ViewportToWorldPoint (new Vector3(posx, posy, 10)));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
