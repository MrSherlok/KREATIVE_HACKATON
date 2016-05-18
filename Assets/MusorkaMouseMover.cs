using UnityEngine;
using System.Collections;

public class MusorkaMouseMover : MonoBehaviour {

	float distance = 10;
	bool gameStart = true;

	void FixedUpdate()
	{
		if (gameStart == true) {
			Vector2 mousePosition = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
			Vector2 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);

			transform.position = objPosition;
								}
	}}