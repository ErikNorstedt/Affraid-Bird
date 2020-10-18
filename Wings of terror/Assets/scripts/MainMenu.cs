using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public int playSceneIndex;
    public void PlayGame()
    {
        SceneManager.LoadScene(playSceneIndex);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
