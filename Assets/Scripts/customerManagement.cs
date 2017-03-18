using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Cusomer {

	public GameObject obj;
	public int mostSuitableAge;
	public int difficulty;
	public int probability;

}

public class customerManagement : MonoBehaviour {

	public Cusomer[] cusomers;

}
