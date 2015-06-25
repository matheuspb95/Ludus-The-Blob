using UnityEngine;
using System.Collections;

public class SpawnMeteor : MonoBehaviour {
	public GameObject [] enemyPrefab;
	public float SpawnTime;
	void Start () {
				InvokeRepeating ("Spawn", SpawnTime, SpawnTime);
		    
	}
	
	void Spawn(){
		float posx = Random.Range (-0.11f, 1.1f);
		while (posx > 0 && posx < 1) {
			posx = Random.Range (-0.1f, 1.1f);
		}
		float posy = Random.Range (-0.1f, 1.1f);
		while (posy > 0 && posy < 1) {
			posy = Random.Range (-0.1f, 1.1f);
		}
		//Debug.Log(""+posx+" - "+posy);
		enemyPrefab[Mathf.RoundToInt(Random.Range(0.0f, 6.0f))].Spawn (Camera.main.ViewportToWorldPoint (new Vector3(posx, posy, 10)));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
