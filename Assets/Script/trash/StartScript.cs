using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StartScript : MonoBehaviour {

    public Text Beg;
    float p = 2f;
    public GameObject hum;
    public GameObject hum1;
    float time=1f;
	void Start()
    {
        hum.active = false;
        hum1.active = false;
        Time.timeScale = 0.2f;
        Beg.enabled = true;
    }

    void Update () {

        time -= Time.deltaTime;
        if (time<=0)
        {
            Beg.enabled = false;
            hum.active = true;
            hum1.active = true;
            Time.timeScale = 1;
        }
	
	}
}
