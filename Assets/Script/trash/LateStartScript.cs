using UnityEngine;
using System.Collections;

public class LateStartScript : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		Time.timeScale = 0.001f;
		Invoke ("Late", 0.002f);
	}

	void Late () {
		Time.timeScale = 1;
	}
}
