using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameButtonsScript : MonoBehaviour {

    public void Reload()
    {
        SceneManager.LoadScene(Application.loadedLevel);
    }
}
