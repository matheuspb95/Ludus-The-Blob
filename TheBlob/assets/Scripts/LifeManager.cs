using UnityEngine;
using System.Collections;

public class LifeManager : MonoBehaviour {
	public int life;
	public float cooldown;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		life = life - KillPlayer.death;
		if (life==0){
			Destroy (gameObject);
			}
	}
}