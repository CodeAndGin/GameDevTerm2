﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class push : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision collision) {
		foreach (ContactPoint contact in collision.contacts) {
//			Debug.DrawRay(contact.point, contact.normal, Color.white);
//			Debug.Log (collision.collider.name);
		}
	}
//	IEnumerator Conveyor(){
////		if(push
//	}
}