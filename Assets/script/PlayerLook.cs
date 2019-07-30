using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour {
	public bool lookingAtRobot;
    //public bool lookingAtTorii;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.CompareTag ("RobotBody")) {
			lookingAtRobot = true;
			Debug.Log ("lookingAtRobot = true");
		} 
	}

	void OnTriggerExit(Collider collider)
	{
		if (collider.gameObject.CompareTag ("RobotBody")) {
			lookingAtRobot = false;
			Debug.Log ("lookingAtRobot = false");
		} 
	}
}
