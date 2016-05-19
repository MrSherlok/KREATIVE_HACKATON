using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class fpsScript : MonoBehaviour {

	float fpsCounter = 0;
	public Text txtFPS;

	void Update () {
		fpsCounter = (int)(1.0 / Time.deltaTime);
		txtFPS.text = "fps: " + fpsCounter.ToString ();
	}
}
