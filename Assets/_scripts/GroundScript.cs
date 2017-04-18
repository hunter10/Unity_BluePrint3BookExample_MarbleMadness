using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour {

	//Button1Script button1;

	void OnCollisionEnter(Collision col){

		//print (col.gameObject.tag + ", " + Button1Script.canBePressed);
		if (col.gameObject.tag == "marble") {
			Button1Script.canBePressed = false;
		}
	}
}
