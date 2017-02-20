using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawBoxMagenta : MonoBehaviour {

	void OnDrawGizmos() {
		Vector3 ext = transform.GetComponent<BoxCollider> ().bounds.extents;
		Gizmos.color = Color.magenta;
		Gizmos.DrawWireCube(transform.position, ext*2);
	}

}
