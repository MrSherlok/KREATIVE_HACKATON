using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KalAttackScript : MonoBehaviour {
    public Text texxt;

    void Start()
    {

        texxt = GameObject.Find("tnt").GetComponent<Text>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "god")
        {
            ScoreScript.m3 = false;
            texxt.text = "You lose";
			SceneManager.LoadScene("SS");
        }
        else {
            Destroy(gameObject);
            BirdInstScript.kal++;
        }
        if (BirdInstScript.kal >= 20)
        {
            ScoreScript.m3 = true;
            texxt.text = "You won";
			SceneManager.LoadScene("SS");

        }

    }

}
