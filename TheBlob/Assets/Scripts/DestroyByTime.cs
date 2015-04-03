using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour {
	public float time;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void DestroyNow () {
		gameObject.Recycle();
	}

	void OnEnable(){
		Invoke ("DestroyNow", time);
	}

} 