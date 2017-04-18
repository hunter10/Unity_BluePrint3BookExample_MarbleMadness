using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleCamera : MonoBehaviour {

	public Transform target;
	float xDist = 5.0f;
	int dmpSpd = 2;
	float height = 3.0f;
	Vector3 newPos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (target != null) {
			newPos = target.position + new Vector3 (-xDist, height, 0);
			transform.position = Vector3.Lerp (transform.position, newPos, Time.deltaTime * dmpSpd);
		}
	}
}
