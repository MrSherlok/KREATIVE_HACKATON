using UnityEngine;
using System.Collections;

public class Spawnpasajirs : MonoBehaviour {
	float a;
	public static float scori;

	public GameObject pas1;
	public GameObject pas2;
	public GameObject pas3;
	public GameObject pas4;
	public void Spawn () {

		a = Random.Range(0,4);
		if(a <1){
			Instantiate(pas1);
		}
		if(a >1 && a<2){
			Instantiate(pas2);
		}
		if(a >2 && a<3){
			Instantiate(pas3);
		}
		if(a >3 && a<4){
			Instantiate(pas4);


		}
	}

}
