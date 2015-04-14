using UnityEngine;
using System.Collections;

public class Reaction : MonoBehaviour {
	public Animator Gosma;
	
	// Use this for initialization
	void Start () {
		Gosma = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			RaycastHit hit;
			Physics.Raycast (Camera.main.ScreenToWorldPoint (Input.mousePosition), Vector3.forward, out hit, 1000);
			Debug.Log (hit.collider);
			Gosma.SetTrigger("Reaction");

		}
		//Mover Bloco Com toque
		foreach (Touch touch in Input.touches) {
			RaycastHit hit;
			Physics.Raycast (Camera.main.ScreenToWorldPoint (touch.position), Vector3.forward, out hit, 1000);
			Debug.Log(hit.collider);
			if (hit.collider!=null && hit.collider.CompareTag ("Player")) {
				//body.velocity = Vector2.zero;
				Gosma.SetTrigger("Reaction");
				}
			}
		}
}