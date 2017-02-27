using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class push : MonoBehaviour {
	public GameObject productManager;
	public float pushingSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay(Collider col) {
		if( productManager.GetComponent<productManagement>().pushProd ){
			Vector3 velocity = col.GetComponent<Rigidbody> ().velocity;

			col.GetComponent<Rigidbody> ().velocity = new Vector3 (-pushingSpeed, velocity.y, velocity.z);
			
		}
	}
//	IEnumerator Conveyor(){
////		if(push
//	}
}
