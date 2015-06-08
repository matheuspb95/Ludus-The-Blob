using UnityEngine;
using System.Collections;

public class AdjustPositionToScreen : MonoBehaviour {
	public Vector3 PositionOnScreen;
	// Use this for initialization
	void Start () {
		transform.position = Camera.main.ViewportToWorldPoint (PositionOnScreen);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
