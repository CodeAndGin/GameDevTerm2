using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixAndRotate: MonoBehaviour {
	float speed = 1000f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

		
	}

	void OnTriggerStay(Collider col){
		if (Camera.main.GetComponent<pickUp> ().inManipulation == false) {
			Transform product = col.GetComponent<Transform> ();
//			float step = speed * Time.deltaTime;
//			product.position = Vector3.MoveTowards(product.position, transform.position, step);

			product.position = transform.position; //

			if (Input.GetButton ("Fire1")) {
				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
				RaycastHit hit;
				int layerMask = 1 << 10;
				if (Physics.Raycast (ray, out hit, 100,layerMask)) {
					if (hit.collider.name == "Rotator") {
						product.Rotate(new Vector3(Input.GetAxis("Mouse Y"), -Input.GetAxis("Mouse X"), 0f) * Time.deltaTime * speed, Space.World); //
					}

				}
			}

		}
	}
}
