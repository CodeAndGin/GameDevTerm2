﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pickUp : MonoBehaviour {
	Transform product;
	public bool inManipulation = true;
	Vector3 point;// = Camera.main.ScreenToWorldPoint (Input.mousePosition);


	void Start () {
		
	}
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			manipulate ();

			if (product) {
				point = Camera.main.ScreenToWorldPoint (Input.mousePosition);
				StartCoroutine ("Translation");
				product.GetComponent<Rigidbody> ().freezeRotation = true;
				product.GetComponent<Rigidbody> ().useGravity = false;
			}
		}

		if (Input.GetButton ("Fire1") && product) {
			inManipulation = true;

//			Vector3 point = Camera.main.ScreenToWorldPoint (Input.mousePosition);
//			point = new Vector3 (point.x, point.y - 15f, product.position.z);
//			Vector3 translation = point - product.position;

		} else {
			StopCoroutine ("Translation");
			inManipulation = false;
			if (product) {
				product.GetComponent<Rigidbody> ().useGravity = true;
				product.GetComponent<Rigidbody> ().freezeRotation = false;
				product = null;
			}
		}

	}

	void manipulate(){
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;
		int layerMask = 1 << 8;

//		Debug.Log (layerMask);
		if (Physics.Raycast (ray, out hit, 100, layerMask)) {
			if (hit.collider.GetComponentInParent<Rigidbody> ()) { //delete in the future
				product = hit.collider.GetComponentInParent<Transform> ();
			}
		}
	}



	IEnumerator Translation(){
		for(;;){
			Vector3 point1 = Camera.main.ScreenToWorldPoint (Input.mousePosition);
						
//						point = new Vector3 (point.x, point.y - 17f, product.position.z);
//						Vector3 translation = point - product.position;
//			Vector3 translation = new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0f);
			Vector3 translation = point1 - point;
	//		Debug.Log (Input.GetAxis ("Mouse X"));
			product.GetComponent<Rigidbody> ().velocity = translation * Time.deltaTime * 3700f;// * 30f;

			point = point1;
			yield return null;
		}
	}
		
}
