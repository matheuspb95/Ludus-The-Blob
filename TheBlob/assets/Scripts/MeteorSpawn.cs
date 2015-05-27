using UnityEngine;
using System.Collections;

public class MeteorSpawn : MonoBehaviour {
	public GameObject Meteor;




	// Use this for initializati

	void Start () {
		InvokeRepeating("CreateObstacle", 1f, 1.5f);
	}

	void CreateObstacle()
	{
		Instantiate(Meteor);
	}
	
}

