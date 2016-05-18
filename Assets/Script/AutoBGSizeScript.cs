using UnityEngine;
using System.Collections;

public class AutoBGSizeScript : MonoBehaviour {
	public static int scrWeight;
	public static int scrHeiht;
	float differentW;
	float differentH;

	void Awake() {
		scrWeight = Screen.width;
		scrHeiht = Screen.height;
	}

	void Start () {
		differentW = scrWeight / 512f;
		differentH = scrHeiht / 320f;
		gameObject.transform.localScale = new Vector3 (differentW, differentH+0.2f, 1);

	}
}
