using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1Script : MonoBehaviour {

	public static bool canBePressed = false;
	//GameObject blockGuard;
	public GameObject tail;
	// Use this for initialization
	void Start () {
		//blockGuard = GameObject.Find ("blockGuard");	
		tail = GameObject.Find("furryPinkTale");
	}

	void OnCollisionEnter(Collision col){

		print (col.gameObject.tag + ", " + canBePressed);

		if (canBePressed == true) {
			StartCoroutine(MoveDown (transform, 0.2f, 1.0f));
			StartCoroutine(MoveTail (tail.transform, 2.4f, 0.4f));

			//gameObject.GetComponent<Renderer> ().material.shader = Shader.Find (" Glossy");
			//gameObject.GetComponent<Renderer> ().material.SetColor ("_SpecColor", Color.red);
			//Destroy (blockGuard);
		}
	}

	IEnumerator MoveDown(Transform thisTransform, float distance, float speed){
		float startPos = thisTransform.position.y;
		float endPos = startPos - distance;
		float rate = 1.0f / Mathf.Abs (startPos - endPos) * speed;
		float t = 0.0f;
		while (t < 1.0f) {
			t += Time.deltaTime * rate;
			thisTransform.position = new Vector3 (thisTransform.position.x,
				Mathf.Lerp (startPos, endPos, t),
				thisTransform.position.z);
			yield return null;
		}
	}

	IEnumerator MoveTail(Transform thisTransform1, float distance1, float speed1){
		float startPos1 = thisTransform1.position.y;
		float endPos1 = startPos1 - distance1;
		float rate1 = 1.0f / Mathf.Abs (startPos1 - endPos1) * speed1;
		float t1 = 0.0f;
		while (t1 < 1.0f) {
			t1 += Time.deltaTime * rate1;
			thisTransform1.position = new Vector3 (thisTransform1.position.x,
				Mathf.Lerp (startPos1, endPos1, t1),
				thisTransform1.position.z);
			yield return null;
		}
	}
}
