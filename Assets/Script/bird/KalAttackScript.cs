using UnityEngine;
using System.Collections;
using UnityEngine.UI;

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
            texxt.text = "You lose";
            Time.timeScale = 0;
        }
        else Destroy(gameObject);

    }

}
