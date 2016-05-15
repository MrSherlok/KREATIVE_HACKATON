using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReloadScript : MonoBehaviour
{
    public void Reload()
    {
        SceneManager.LoadScene(Application.loadedLevel);
        Time.timeScale = 1;
        Musordetector.litterMiss = 0;
        Musordetector.litterDel = 0;
    }

}
