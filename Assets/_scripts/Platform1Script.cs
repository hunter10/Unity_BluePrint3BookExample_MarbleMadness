using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform1Script : MonoBehaviour {

	public float speed = 0.5f;
	Vector3 startPosition;
	public float moveDistance = 1.0f;

	// Use this for initialization
	void Start () {
		startPosition = transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		//print (speed + " " + moveDistance);
		//float x = Mathf.PingPong (Time.time * speed, moveDistance);

		//print (x);

		Vector3 temp = new Vector3 (0, 0, Mathf.PingPong (Time.time * speed, moveDistance));
		//print(temp);


		transform.position = startPosition + temp;
	}
}
