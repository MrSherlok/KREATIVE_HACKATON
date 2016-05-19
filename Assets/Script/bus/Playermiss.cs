using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Playermiss : MonoBehaviour {
	public static float a =0.0f;
	public float inv;
	public Transform spawnpoint;
	public GameObject pas1;
	public GameObject pas2;
	public GameObject pas3;
	public GameObject pas4;
	public Image UIButt;

	float itsyoutime;
	float randomizer;

	void Start(){
		Time.timeScale = 1f;
		UIButt.enabled = false;
		Invoke("Spawn",inv);
	}
	void OnTriggerEnter2D(Collider2D end)
	{
		if (end.tag == "Pasajir") {

			Debug.Log ("Nice");
			Destroy (end.gameObject);
			randomizer = Random.Range (0f,0.5f);
			Invoke("Spawn",randomizer );

		}
		if (end.tag == "Babka") {

			Debug.Log ("False");
            Debug.Log("You Lose");
            ScoreScript.mainScore += 0;
            ScoreScript.m2 = false;
			SceneManager.LoadScene("SadScene");
		
        }
	}
	public void Spawn () {

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
