using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pickUp : MonoBehaviour {
	Transform product;
	public bool inManipulation = true;

	void Start () {
		
	}
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			manipulate ();
		}

		if (Input.GetButton ("Fire1") && product) {
			inManipulation = true;
			Vector3 point = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			point = new Vector3 (point.x, point.y - 15f, product.position.z);
			Vector3 translation = point - product.position;
			product.GetComponent<Rigidbody> ().velocity = translation * 10f;
			product.GetComponent<Rigidbody> ().freezeRotation = true;
		} else {
			inManipulation = false;
			product.GetComponent<Rigidbody> ().freezeRotation = false;
			product = null;
		}

	}

	void manipulate(){
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;
		int layerMask = 1 << 8;
		Debug.Log (layerMask);
		if (Physics.Raycast (ray, out hit, 100, layerMask)) {
			if (hit.collider.GetComponentInParent<Rigidbody> ()) {
				product = hit.collider.GetComponentInParent<Transform> ();
			}
		}
	}
		
}
