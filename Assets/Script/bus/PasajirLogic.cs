using UnityEngine;
using System.Collections;

public class PasajirLogic : MonoBehaviour {

	public Vector2 speed = new Vector2(2, 2); 
	public static float dirPas;
	public Vector2 direction = new Vector2(1f, 0f); 
	float speedByTime; 

	void Start () {
		direction.x = dirPas;
		if (dirPas == -1) {
				gameObject.transform.eulerAngles = new Vector3 (0f, 180f, 0f);
				direction.x = 1;
			}
		else gameObject.transform.eulerAngles = new Vector3(0f, 0f, 0f);
	}

	void FixedUpdate ()
	{ 

		Vector3 movement = new Vector3 (speed.x * direction.x, speed.y * direction.y, 0); 
		movement *= Time.deltaTime; 
		transform.Translate (movement);
	}
}