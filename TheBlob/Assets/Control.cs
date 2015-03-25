using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour {
	private Rigidbody2D body;
	public float Acceleration=1;
	// Use this for initialization
	void Start () {
		body = transform.parent.rigidbody2D;
	}
	
	// Update is called once per frame
	void Update () {
//		if (Input.GetMouseButton (0)) {
//			RaycastHit hit;
//			Physics.Raycast (Camera.main.ScreenToWorldPoint (Input.mousePosition), Vector3.forward, out hit, 1000);
//			Debug.Log (hit.collider);
//		}
		//Mover Bloco Com toque
		foreach (Touch touch in Input.touches) {
			RaycastHit hit;
			Physics.Raycast (Camera.main.ScreenToWorldPoint (touch.position), Vector3.forward, out hit, 1000);
			Debug.Log(hit.collider);
			if (hit.collider!=null && hit.collider.CompareTag ("Player")) {
				if (touch.phase == TouchPhase.Moved) {
					body.AddForce (touch.deltaPosition * Acceleration);
				}	
			}	
		}
	}
}
