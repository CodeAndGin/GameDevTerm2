using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawBoxGreen : MonoBehaviour {
	
	void OnDrawGizmos() {
		Vector3 ext = transform.GetComponent<BoxCollider> ().bounds.extents;
		Gizmos.color = Color.green;
		Gizmos.DrawWireCube(transform.position, ext*2);
	}

}
