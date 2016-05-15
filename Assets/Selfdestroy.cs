using UnityEngine;
using System.Collections;

public class Selfdestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(gameObject,3f);
	}

}
