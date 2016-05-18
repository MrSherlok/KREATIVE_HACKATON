using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerStandUp : MonoBehaviour {
	public float z;
	int score;
	Animator ani;
	public GameObject obj;
	// Use this for initialization
	void Start(){
		ani = obj.GetComponent<Animator> ();
	}
	public void StandUp () {
		ani.SetTrigger ("StandUp");
		
		Debug.Log ("I STAND UP!");
		if (z > 2.4) {
			Debug.Log (" You Won");
            
			score = 100;
            ScoreScript.mainScore += 100;
            ScoreScript.m2 = true;
			SceneManager.LoadScene("GoodScene");
        }
		if (z < 2.4) {
			Debug.Log ("You Lose");
			ScoreScript.mainScore += 0;
            ScoreScript.m2 = false;
			SceneManager.LoadScene("SadScene");
        }
	}
	void Update(){
		z = Playermiss.a;
	}
	

}
