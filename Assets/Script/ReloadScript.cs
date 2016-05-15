using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReloadScript : MonoBehaviour
{
    public void Reload()
    {
        SceneManager.LoadScene("01");
        Time.timeScale = 1;
        Musordetector.litterMiss = 0;
        Musordetector.litterDel = 0;
        ScoreScript.m1 = false;
        ScoreScript.m2 = false;
        ScoreScript.m3 = false;
        BirdInstScript.kal = 0;
    }

}
