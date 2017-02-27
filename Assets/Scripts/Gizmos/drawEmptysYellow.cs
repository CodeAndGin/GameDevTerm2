using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawEmptysYellow : MonoBehaviour {

	void OnDrawGizmos() {
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireCube(transform.position, new Vector3(0.5f,0.5f,0.5f));
	}

}
