using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameButtonsScript : MonoBehaviour {
    public Text lvl1Score;
    public Text lvl2Score;
    public void Reload()
    {
        SceneManager.LoadScene(Application.loadedLevel);
        Time.timeScale = 1;
        Musordetector.litterMiss = 0;
        Musordetector.litterDel = 0;
    }

    //void Start()
    //{
    //    lvl1Score.text = "Score: ";
    //    lvl2Score.text = "Score miss: " ;

    //}

    void Update()
    {
        lvl1Score.text = "Score: " + Musordetector.litterDel.ToString();
        lvl2Score.text = "Score miss: " + Musordetector.litterMiss.ToString();
        if (Musordetector.litterMiss >= 5)
        {
            lvl2Score.text = "You are dead"; Time.timeScale = 0;
        }

    }
}
