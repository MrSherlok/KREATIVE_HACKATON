using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Playermiss : MonoBehaviour {
	public float a =0.0f;
	public float inv;
	public Transform spawnpoint;
	public GameObject pas1;
	public GameObject pas2;
	public GameObject pas3;
	public GameObject pas4;
	public Image UIButt;

//	float randomizer;
	float timeBus = 1.5f;

	void Start(){
		Time.timeScale = 1f;
		UIButt.enabled = false;
	}

	void Update () {
		timeBus -= Time.deltaTime;
		if (timeBus <= 0f) {
			timeBus = Random.Range (1.5f, 2.5f);
			UIButt.enabled = true;
			a = Random.Range(0f,3.2f);
			if (gameObject.name == "target1")
				PasajirLogic.dirPas = -1f;
			else PasajirLogic.dirPas = 1f;
			if(a<=1){
				Instantiate(pas1,spawnpoint.position,spawnpoint.rotation);
			}
			if(a>1 && a<=2){
				Instantiate(pas2,spawnpoint.position,spawnpoint.rotation);
			}
			if(a>2 && a<=2.8){
				Instantiate(pas3,spawnpoint.position,spawnpoint.rotation);
			}
			if(a>2.8){
				Instantiate(pas4,spawnpoint.position,spawnpoint.rotation);
			}
		}
	}


	void OnTriggerEnter2D(Collider2D end)
	{
		if (end.tag == "Pasajir") {

			Debug.Log ("Nice");
			Destroy (end.gameObject);
		}
		if (end.tag == "Babka") {

			Debug.Log ("False");
            Debug.Log("You Lose");
            ScoreScript.mainScore += 0;
            ScoreScript.m2 = false;
			SceneManager.LoadScene("SadScene");
		
        }
	}
}
