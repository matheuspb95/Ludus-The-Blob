using UnityEngine;
using System.Collections;

public class FoodControl : MonoBehaviour {
	public float chance;
	public GameObject Food;
	public void CanISpawn(Vector3 position){
		if (Random.Range (0.0f, 100f) >= this.chance) {
			Instantiate(Food,position,transform.rotation);
		}
	}
	// Use this for initialization
	void Start () {

	}
	// Update is called once per frame
	void Update () {
	
	}
}
