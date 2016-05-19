using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerStandUp : MonoBehaviour {
	int score;
	Animator ani;
	bool babkaOnMe = false;
	// Use this for initialization
	void Start(){
		ani = gameObject.GetComponent<Animator> ();
	}
	public void StandUp () {
		ani.SetTrigger ("StandUp");
		
		Debug.Log ("I STAND UP!");
		if (babkaOnMe == true) {
			Debug.Log (" You Won");
            
			score = 100;
            ScoreScript.mainScore += 100;
            ScoreScript.m2 = true;
			SceneManager.LoadScene("GoodScene");
        }
		if (babkaOnMe == false) {
			Debug.Log ("You Lose");
			ScoreScript.mainScore += 0;
            ScoreScript.m2 = false;
			SceneManager.LoadScene("SadScene");
        }
	}


	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Babka")
			babkaOnMe = true;
	}

	void OnTriggerExit2D (Collider2D other) {
		if (other.tag == "Babka")
			babkaOnMe = false;
	}

}
