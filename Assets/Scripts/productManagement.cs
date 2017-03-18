using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Product {

	public GameObject obj;//{ get; set; }
//	public bool ageRestricted;//{ get; set; } //Ideas for the future
	public int mostSuitableAge;//{ get; set; }
	public int difficulty;//{ get; set; }
	public int probability;//{ get; set; }

//	public Product(GameObject Obj, int[] AgeRange, int MostSuitableAge, int Difficulty, int Probability){
//
//		obj = Obj;
//		ageRange = AgeRange;
//		mostSuitableAge = MostSuitableAge;
//		difficulty = Difficulty;
//		probability = Probability;
//	
//	}





}


/*Instantiates new products and translates them closer to a til point*/
public class productManagement : MonoBehaviour {
	public bool pushProd = true;
//	public float speed = 100.0f;
//	int counter = 0;


//	public GameObject[] obj;
	public Transform spawningPoint;

	public Product[] products;
	// Use this for initialization
	void Start () {
//		StartCoroutine ("Instance");

	}
	
	// Update is called once per frame
	void Update () {
//		pushProd = true;
	}

//	IEnumerator Instance(){
//		for(;;) {
//			GameObject newProd = Instantiate(product, new Vector3(newProdPos.position.x, newProdPos.position.y,newProdPos.position.z + Random.Range(-2.0f, 2.0f)), Quaternion.identity) as GameObject;
////			StartCoroutine ("Conveyor", newProd);
////			counter++;
//			yield return new WaitForSeconds (2);
////			yield return null;
//		}
//	}

//	IEnumerator Conveyor(GameObject product){
//		
//		for (;;) {
//			if (pushProd) {
//				Vector3 velocity = product.GetComponent<Rigidbody> ().velocity;
//				product.GetComponent<Rigidbody> ().velocity = new Vector3(-(speed * Time.deltaTime), velocity.y, velocity.z);
//			}
//			yield return null;
//		}
//	}
}
