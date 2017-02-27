using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beltStopper : MonoBehaviour {
	public GameObject productManager;

	int count = 0;

	void Start(){
		StartCoroutine ("push");
	}

	void OnTriggerStay(Collider col){
		count = 0;
	}

	IEnumerator push(){
		for (;;) {
			if (count > 0) {
				productManager.GetComponent<productManagement> ().pushProd = true;
			} else {
				productManager.GetComponent<productManagement> ().pushProd = false;
			}
			count++;
			yield return new WaitForSeconds (0.1f);
		}
	}

//	void OnTriggerEnter(Collider col){
//		count++;
//		productManager.GetComponent<productManagement> ().pushProd = false;
//		Debug.Log ("stop");
//	}
//
//	void OnTriggerExit(Collider col){
//		count--;
//	}
//
//	void Update(){
//		Debug.Log (count);
//		if (count == 0) {
//			Debug.Log ("start");
//			productManager.GetComponent<productManagement> ().pushProd = true;
//		} else {
//			Debug.Log ("notMoving");
//		}
//	}

}
