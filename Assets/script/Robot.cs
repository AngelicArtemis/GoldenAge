using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour {
	public bool playerClose = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.CompareTag ("Player")) {
			playerClose = true;
			Debug.Log ("playerClose = true");
		}
	}

	void OnTriggerExit(Collider collider)
	{
		if (collider.gameObject.CompareTag ("Player")) {
			playerClose = false;
			Debug.Log ("playerClose = false");
		}
	}
}
