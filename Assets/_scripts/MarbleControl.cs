using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleControl : MonoBehaviour {

	float marbleSpeed = 15.0f;

	//void Update(){
	void FixedUpdate(){
		//Vector3 torque = new Vector3 (Input.GetAxis ("Horizontal") * marbleSpeed, 0, Input.GetAxis ("Vertical") * marbleSpeed);
		Vector3 torque = new Vector3 (Input.GetAxis ("Vertical") * marbleSpeed, 0, Input.GetAxis ("Horizontal") * -marbleSpeed);
		gameObject.GetComponent<Rigidbody> ().AddForce (torque, ForceMode.Force);
	}
}
