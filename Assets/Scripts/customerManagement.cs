//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class faceImages{
	public GameObject happy;
	public GameObject neutral;
	public GameObject sad;
	public GameObject angry;
	public GameObject furious;
}

[System.Serializable]
public class Customer {

	public GameObject obj;

	public int difficulty;
	public int age;

}

public class customerManagement : MonoBehaviour {

	public faceImages face;
	public Customer[] customers;

}
