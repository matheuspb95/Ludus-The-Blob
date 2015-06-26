using UnityEngine;
using System.Collections;

public class SpawnMeteor : MonoBehaviour {
	public GameObject [] enemyPrefab;
	public float SpawnTime;
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
		enemyPrefab[Mathf.RoundToInt(Random.Range(0.0f, 6.0f))].Spawn (Camera.main.ViewportToWorldPoint (new Vector3(posx, posy, 10)));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
