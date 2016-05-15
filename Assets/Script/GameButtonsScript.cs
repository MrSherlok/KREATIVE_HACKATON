﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameButtonsScript : MonoBehaviour {
    public Text lvl1Score;
    public Text lvl2Score;
    int _q;
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
        if (Musordetector.litterDel >= 50)
        {
            lvl1Score.text = "You are won"; 
            ScoreScript.mainScore += 100;
            Invoke("Load", 1f);
        }
        lvl2Score.text = "Score miss: " + Musordetector.litterMiss.ToString();
        if (Musordetector.litterMiss >= 5)
        {
            lvl2Score.text = "You are dead"; 
            Invoke("Load", 1f);
        }

        
    }
    void Load ()
    {
        _q = Random.Range(0, 3);
        Time.timeScale = 1;
        Application.LoadLevel("0"+_q.ToString());
        
    }
}
