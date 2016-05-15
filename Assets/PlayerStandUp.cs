using UnityEngine;
using System.Collections;

public class PlayerStandUp : MonoBehaviour {
	public float z;
	int score;
	Animator ani;
	public GameObject obj;
	// Use this for initialization
	void Start(){
		ani = obj.GetComponent<Animator> ();
	}
	 void StandUp () {
		ani.SetTrigger ("StandUp");
		
		Debug.Log ("I STAND UP!");
		if (z > 2.4) {
			Debug.Log (" You Won");
            
			score = 100;
            ScoreScript.mainScore += 100;
            ScoreScript.m2 = true;
            Application.LoadLevel("GoodScene");
        }
		if (z < 2.4) {
			Debug.Log ("You Lose");
			ScoreScript.mainScore += 0;
            ScoreScript.m2 = false;
            Application.LoadLevel("SadScene");
        }
	}
	void Update(){
		z = Playermiss.a;
	}
	

}
