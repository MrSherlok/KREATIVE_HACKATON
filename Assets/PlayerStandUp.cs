using UnityEngine;
using System.Collections;

public class PlayerStandUp : MonoBehaviour {
	public float z;
	Animator ani;
	// Use this for initialization
	 void StandUp () {
		
		Debug.Log ("I STAND UP!");
		if (z > 2.4) {
			Debug.Log (" You Won");
		}
		if (z < 2.4) {
			Debug.Log ("You Lose");
		}
	}
	void Update(){
		z = Playermiss.a;
	}
	

}
