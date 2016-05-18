using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("Next", 3);
	}
	
	// Update is called once per frame
	void Next () {
		SceneManager.LoadScene("03");
	
	}
}
