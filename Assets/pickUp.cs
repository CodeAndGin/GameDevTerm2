using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pickUp : MonoBehaviour {
	bool hold = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
				manipulate ();
		}

	}

	void manipulate(){
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);


		if (hold) { // Then throw a body forward
			hold = false;
		}else {
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit, 100)) {
				if (hit.collider.GetComponentInParent<Rigidbody> ()) {
					hold = true;
//					manipulatedBody = hit.collider.GetComponentInParent<Transform> ();
					StartCoroutine ("Manipulation");
				}
			}
		}

	}

	IEnumerator Manipulation() {
		while(hold){
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			Vector3 point = Camera.main.ScreenToWorldPoint (Input.mousePosition);//.position + (ray.direction * distToBodyAllreadyManipIcr);
			Vector3 translation = point - transform.position;
			transform.GetComponent<Rigidbody> ().velocity = translation * 10f;

			yield return null;
		}
	}
}
