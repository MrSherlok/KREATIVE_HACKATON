﻿using UnityEngine;
using System.Collections;

public class Playermiss : MonoBehaviour {
	public static float a =0.0f;
	public Transform spawnpoint;
	public GameObject pas1;
	public GameObject pas2;
	public GameObject pas3;
	public GameObject pas4;

	float itsyoutime;

	void Start(){
		Invoke("Spawn",3);
	}
	void OnTriggerEnter2D(Collider2D end)
	{
		if (end.tag == "Pasajir") {

			Debug.Log ("Nice");
			Destroy (end.gameObject);
			Spawn ();
		}
		if (end.tag == "Babka") {

			Debug.Log ("False");
            Debug.Log("You Lose");
            ScoreScript.mainScore += 0;
            ScoreScript.m2 = false;
            Application.LoadLevel("SadScene");



        }
	}
	public void Spawn () {


		a = Random.Range(0f,3.2f);
		if(a<1){
			Instantiate(pas1,spawnpoint.transform.position,spawnpoint.transform.rotation);
		}
		if(a>1 && a<2){
			Instantiate(pas2,spawnpoint.transform.position,spawnpoint.transform.rotation);
		}
		if(a>2 && a<2.4){
			Instantiate(pas3,spawnpoint.transform.position,spawnpoint.transform.rotation);
		}
		if(a>2.4){
			Instantiate(pas4,spawnpoint.transform.position,spawnpoint.transform.rotation);
		}
		Debug.Log(a);
	}

}
