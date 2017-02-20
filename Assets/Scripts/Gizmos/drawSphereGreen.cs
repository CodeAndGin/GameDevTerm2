using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawSphereGreen: MonoBehaviour {

	void OnDrawGizmos() {
		float ext = transform.GetComponent<SphereCollider> ().radius;
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(transform.position, ext);
	}

}
