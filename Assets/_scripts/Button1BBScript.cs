using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1BBScript : MonoBehaviour {

	//public Button1Script button1;

	void OnTriggerEnter(Collider col){
		print (col.gameObject.tag);

		Button1Script.canBePressed = true;
	}

}
